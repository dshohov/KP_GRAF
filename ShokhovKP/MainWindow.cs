using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ShokhovKP
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool IsDirected = false;
        
        private void DemoButton_Click(object sender, EventArgs e)
        {
            FO fo = new FO((int)numberNodes.Value, (int)numberEdges.Value, false);
            fo.fo = fo.CreateFO(fo.Matrix);
            FOBox.Text = String.Join(" ", fo.fo);

            DemoGraph demo = new DemoGraph(fo);
            demo.Show();
        }

        private void listOfSubGraphBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Clique selectClique = (Clique)lb.SelectedItem;
            BuildGraphs(pictureGraphBox1, CompareGraphs.FO1, CompareGraphs.Clique1.First(x => x.Equals(selectClique)));
        }

        private void listOfSubGraphBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Clique selectClique = (Clique)lb.SelectedItem;
            BuildGraphs(pictureGraphBox2, CompareGraphs.FO2, CompareGraphs.Clique2.First(x => x.Equals(selectClique)));
        }

        #region Create, build and found cliques in selected graph
        private void BuildGraph1_Click(object sender, EventArgs e)
        {
            MakeGraphAndAnalyze(pictureGraphBox1, listOfSubGraphBox1, 1);
        }
        
        private void BuildGraph2_Click(object sender, EventArgs e)
        {
            MakeGraphAndAnalyze(pictureGraphBox2, listOfSubGraphBox2, 2);
        }

        private void MakeGraphAndAnalyze(PictureBox picture, ListBox listBox, int numberGraph)
        {
            errorProvider1.Clear();
            FO fo;
            try
            {
                fo = CreateGraph();
                if (numberGraph == 1)
                    CompareGraphs.FO1 = fo;
                else if(numberGraph == 2)
                    CompareGraphs.FO2 = fo;
            }
            catch
            {
                errorProvider1.SetError(FOBox, "Помилка в введеному форматі графу!");
                return;
            }
            BuildGraphs(picture, fo);
            CreateListClique(listBox, fo, numberGraph);
            if(CompareGraphs.Clique1 != null && CompareGraphs.Clique2 != null)
            {
                CompareGraphs cg = new CompareGraphs();
                cg.Compare();
                summaryBox.Text = cg.ToString();
            }
        }
        private void BuildGraphs(PictureBox picture, FO fo)
        {
            PaintGraph pg = new PaintGraph(picture, fo.Matrix);
            pg.DrawGraph();
        }
        private void BuildGraphs(PictureBox picture, FO fo, Clique clique)
        {
            PaintGraph pg = new PaintGraph(picture, fo.Matrix);
            pg.DrawGraph(clique.Nodes);
        }
        private FO CreateGraph()
        {
            string FO = FOBox.Text;
            FO fo = new FO(FO.Split(' ').Select(x => int.Parse(x)).ToArray());
            fo.fo = fo.CreateFO(fo.Matrix);//<------------------delete this
            return fo;
        }
        private void CreateListClique(ListBox listBox, FO fo, int numberGraph)
        {
            listBox.Items.Clear();
            //BronKerbosch bk = new BronKerbosch(fo.Matrix, IsDirected);
            GFG gfg = new GFG(fo.Matrix, IsDirected);
            List<Clique> clique = gfg.FoundClique(); //bk.FindAllCliques();
            for(int i = 0; i < clique.Count; i++)
            {
                listBox.Items.Add(clique[i]);
            }
            if (numberGraph == 1)
                CompareGraphs.Clique1 = clique;
            else
                CompareGraphs.Clique2 = clique;
        }

        private void pictureGraphBox1_Click(object sender, EventArgs e)
        {
            if (CompareGraphs.FO1 != null)
                BuildGraphs(pictureGraphBox1, CompareGraphs.FO1);
        }

        private void pictureGraphBox2_Click(object sender, EventArgs e)
        {
            if (CompareGraphs.FO2 != null)
                BuildGraphs(pictureGraphBox2, CompareGraphs.FO2);
        }

        #endregion

        #region About
        private void aboutProgram_Click(object sender, EventArgs e)
        {
            Process.Start("Информация про ПО.docx");
        }

        private void aboutGraph1_Click(object sender, EventArgs e)
        {
            if(CompareGraphs.FO1 != null)
                FOBox.Text = String.Join(" ", CompareGraphs.FO1.fo);
        }

        private void aboutGraph2_Click(object sender, EventArgs e)
        {
            if (CompareGraphs.FO2 != null)
                FOBox.Text = String.Join(" ", CompareGraphs.FO2.fo);
        }

        private void aboutAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Шохов Дмитро, студент 525б групи");
        }
        #endregion

        #region save & load
        private void saveGraphs_Click(object sender, EventArgs e)
        {
            if (CompareGraphs.FO1.fo == null || CompareGraphs.FO2.fo == null)
            {
                MessageBox.Show("Створіть обидва графи, а потім спробуйте ще раз!");
                return;
            }
            else
            {
                try
                {
                    string text = String.Join(" ", CompareGraphs.FO1.fo) + "\n" +
                                  String.Join(" ", CompareGraphs.FO2.fo);
                    SaveFileDialog sfd = new SaveFileDialog();
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string namefile = sfd.FileName;
                        File.WriteAllText(namefile, text);
                    }
                }
                catch
                {
                    MessageBox.Show("Несподівана помилка!");
                    return;
                }
            }
        }

        private void loadGraphs_Click(object sender, EventArgs e)
        {
            //try
            //{
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] graphs = File.ReadAllLines(ofd.FileName);
                    CompareGraphs.FO1 = new FO(graphs[0].Split(' ').Select(x => int.Parse(x)).ToArray());
                    FOBox.Text = String.Join(" ", CompareGraphs.FO1.fo);
                    MakeGraphAndAnalyze(pictureGraphBox1, listOfSubGraphBox1, 1);

                    CompareGraphs.FO2 = new FO(graphs[1].Split(' ').Select(x => int.Parse(x)).ToArray());
                    FOBox.Text = String.Join(" ", CompareGraphs.FO2.fo);
                    MakeGraphAndAnalyze(pictureGraphBox2, listOfSubGraphBox2, 2);
                }
            //}
            //catch
            //{
            //    MessageBox.Show("Файл має невірне представлення даних!");
            //}
        }
        #endregion
        
        private void IsDirectedEdges_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox cb = (ToolStripComboBox)sender;
            if (!cb.SelectedItem.Equals("Не враховується"))
                IsDirected = true;
            else
                IsDirected = false;
        }
    }
}
