using System;
using System.Windows.Forms;

namespace ShokhovKP
{
    public partial class DemoGraph : Form
    {
        public DemoGraph(FO fo)
        {
            this.fo = fo;
            InitializeComponent();
        }

        private FO fo;

        private void CloseDemo(object sender, EventArgs e)
        {
            Close();
        }

        private void DemoGraph_Load(object sender, EventArgs e)
        {
            PaintGraph pg = new PaintGraph(pictureBox1, fo.Matrix);
            pg.DrawGraph();
        }
    }
}
