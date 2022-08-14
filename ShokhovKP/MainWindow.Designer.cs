namespace ShokhovKP
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заполнениеГрафовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGraphs = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGraphs = new System.Windows.Forms.ToolStripMenuItem();
            this.побудуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildGraph1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildGraph2 = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGraph1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGraph2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.IsDirectedEdges = new System.Windows.Forms.ToolStripComboBox();
            this.FOBox = new System.Windows.Forms.RichTextBox();
            this.pictureGraphBox1 = new System.Windows.Forms.PictureBox();
            this.listOfSubGraphBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureGraphBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listOfSubGraphBox2 = new System.Windows.Forms.ListBox();
            this.numberEdges = new System.Windows.Forms.NumericUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numberNodes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.DemoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.summaryBox = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGraphBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGraphBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberEdges)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberNodes)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заполнениеГрафовToolStripMenuItem,
            this.побудуватиToolStripMenuItem,
            this.інформаціяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1245, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заполнениеГрафовToolStripMenuItem
            // 
            this.заполнениеГрафовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGraphs,
            this.loadGraphs});
            this.заполнениеГрафовToolStripMenuItem.Name = "заполнениеГрафовToolStripMenuItem";
            this.заполнениеГрафовToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.заполнениеГрафовToolStripMenuItem.Text = "Файл";
            // 
            // saveGraphs
            // 
            this.saveGraphs.Name = "saveGraphs";
            this.saveGraphs.Size = new System.Drawing.Size(228, 26);
            this.saveGraphs.Text = "Зберегти графи";
            this.saveGraphs.Click += new System.EventHandler(this.saveGraphs_Click);
            // 
            // loadGraphs
            // 
            this.loadGraphs.Name = "loadGraphs";
            this.loadGraphs.Size = new System.Drawing.Size(228, 26);
            this.loadGraphs.Text = "Завантажити графи";
            this.loadGraphs.Click += new System.EventHandler(this.loadGraphs_Click);
            // 
            // побудуватиToolStripMenuItem
            // 
            this.побудуватиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuildGraph1,
            this.BuildGraph2});
            this.побудуватиToolStripMenuItem.Name = "побудуватиToolStripMenuItem";
            this.побудуватиToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.побудуватиToolStripMenuItem.Text = "Побудувати";
            // 
            // BuildGraph1
            // 
            this.BuildGraph1.Name = "BuildGraph1";
            this.BuildGraph1.Size = new System.Drawing.Size(224, 26);
            this.BuildGraph1.Text = "Перший граф";
            this.BuildGraph1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BuildGraph1.Click += new System.EventHandler(this.BuildGraph1_Click);
            // 
            // BuildGraph2
            // 
            this.BuildGraph2.Name = "BuildGraph2";
            this.BuildGraph2.Size = new System.Drawing.Size(224, 26);
            this.BuildGraph2.Text = "Другий граф";
            this.BuildGraph2.Click += new System.EventHandler(this.BuildGraph2_Click);
            // 
            // інформаціяToolStripMenuItem
            // 
            this.інформаціяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgram,
            this.aboutGraph,
            this.aboutAuthor,
            this.toolStripMenuItem1});
            this.інформаціяToolStripMenuItem.Name = "інформаціяToolStripMenuItem";
            this.інформаціяToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.інформаціяToolStripMenuItem.Text = "Інформація";
            // 
            // aboutProgram
            // 
            this.aboutProgram.Name = "aboutProgram";
            this.aboutProgram.Size = new System.Drawing.Size(285, 26);
            this.aboutProgram.Text = "Про програму";
            this.aboutProgram.Click += new System.EventHandler(this.aboutProgram_Click);
            // 
            // aboutGraph
            // 
            this.aboutGraph.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutGraph1,
            this.aboutGraph2});
            this.aboutGraph.Name = "aboutGraph";
            this.aboutGraph.Size = new System.Drawing.Size(285, 26);
            this.aboutGraph.Text = "Про граф";
            // 
            // aboutGraph1
            // 
            this.aboutGraph1.Name = "aboutGraph1";
            this.aboutGraph1.Size = new System.Drawing.Size(150, 26);
            this.aboutGraph1.Text = "Перший";
            this.aboutGraph1.Click += new System.EventHandler(this.aboutGraph1_Click);
            // 
            // aboutGraph2
            // 
            this.aboutGraph2.Name = "aboutGraph2";
            this.aboutGraph2.Size = new System.Drawing.Size(150, 26);
            this.aboutGraph2.Text = "Другий";
            this.aboutGraph2.Click += new System.EventHandler(this.aboutGraph2_Click);
            // 
            // aboutAuthor
            // 
            this.aboutAuthor.Name = "aboutAuthor";
            this.aboutAuthor.Size = new System.Drawing.Size(285, 26);
            this.aboutAuthor.Text = "Про автора";
            this.aboutAuthor.Click += new System.EventHandler(this.aboutAuthor_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IsDirectedEdges});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(285, 26);
            this.toolStripMenuItem1.Text = "Враховувати напрям ребер";
            // 
            // IsDirectedEdges
            // 
            this.IsDirectedEdges.Items.AddRange(new object[] {
            "Не враховується",
            "Враховується"});
            this.IsDirectedEdges.Name = "IsDirectedEdges";
            this.IsDirectedEdges.Size = new System.Drawing.Size(180, 28);
            this.IsDirectedEdges.Text = "Не враховується";
            this.IsDirectedEdges.SelectedIndexChanged += new System.EventHandler(this.IsDirectedEdges_SelectedIndexChanged);
            // 
            // FOBox
            // 
            this.FOBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FOBox.Location = new System.Drawing.Point(4, 19);
            this.FOBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FOBox.Name = "FOBox";
            this.FOBox.Size = new System.Drawing.Size(797, 56);
            this.FOBox.TabIndex = 6;
            this.FOBox.Text = "2 10 0 1 7 0 1 6 0 3 0 1 6 10 0 2 3 4 0 4 6 0 9 0 3 0 0";
            // 
            // pictureGraphBox1
            // 
            this.pictureGraphBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureGraphBox1.Location = new System.Drawing.Point(4, 19);
            this.pictureGraphBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureGraphBox1.Name = "pictureGraphBox1";
            this.pictureGraphBox1.Size = new System.Drawing.Size(400, 370);
            this.pictureGraphBox1.TabIndex = 9;
            this.pictureGraphBox1.TabStop = false;
            this.pictureGraphBox1.Click += new System.EventHandler(this.pictureGraphBox1_Click);
            // 
            // listOfSubGraphBox1
            // 
            this.listOfSubGraphBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOfSubGraphBox1.FormattingEnabled = true;
            this.listOfSubGraphBox1.ItemHeight = 16;
            this.listOfSubGraphBox1.Location = new System.Drawing.Point(4, 19);
            this.listOfSubGraphBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listOfSubGraphBox1.Name = "listOfSubGraphBox1";
            this.listOfSubGraphBox1.Size = new System.Drawing.Size(279, 135);
            this.listOfSubGraphBox1.TabIndex = 10;
            this.listOfSubGraphBox1.SelectedIndexChanged += new System.EventHandler(this.listOfSubGraphBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureGraphBox1);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(408, 393);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Перший граф";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureGraphBox2);
            this.groupBox2.Location = new System.Drawing.Point(432, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(408, 393);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Другий граф";
            // 
            // pictureGraphBox2
            // 
            this.pictureGraphBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureGraphBox2.Location = new System.Drawing.Point(4, 19);
            this.pictureGraphBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureGraphBox2.Name = "pictureGraphBox2";
            this.pictureGraphBox2.Size = new System.Drawing.Size(400, 370);
            this.pictureGraphBox2.TabIndex = 9;
            this.pictureGraphBox2.TabStop = false;
            this.pictureGraphBox2.Click += new System.EventHandler(this.pictureGraphBox2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FOBox);
            this.groupBox3.Location = new System.Drawing.Point(16, 431);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(824, 79);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FO - графу";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listOfSubGraphBox1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(4, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(287, 158);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Першого графу";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Location = new System.Drawing.Point(16, 514);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(596, 181);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Повні підграфи";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listOfSubGraphBox2);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox6.Location = new System.Drawing.Point(305, 19);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(287, 158);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Другого графу";
            // 
            // listOfSubGraphBox2
            // 
            this.listOfSubGraphBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOfSubGraphBox2.FormattingEnabled = true;
            this.listOfSubGraphBox2.ItemHeight = 16;
            this.listOfSubGraphBox2.Location = new System.Drawing.Point(4, 19);
            this.listOfSubGraphBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listOfSubGraphBox2.Name = "listOfSubGraphBox2";
            this.listOfSubGraphBox2.Size = new System.Drawing.Size(279, 135);
            this.listOfSubGraphBox2.TabIndex = 10;
            this.listOfSubGraphBox2.SelectedIndexChanged += new System.EventHandler(this.listOfSubGraphBox2_SelectedIndexChanged);
            // 
            // numberEdges
            // 
            this.numberEdges.Location = new System.Drawing.Point(139, 32);
            this.numberEdges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberEdges.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numberEdges.Name = "numberEdges";
            this.numberEdges.Size = new System.Drawing.Size(65, 22);
            this.numberEdges.TabIndex = 16;
            this.numberEdges.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.numberNodes);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.DemoButton);
            this.groupBox7.Controls.Add(this.numberEdges);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Location = new System.Drawing.Point(620, 514);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(220, 127);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Випадковий граф";
            // 
            // numberNodes
            // 
            this.numberNodes.Location = new System.Drawing.Point(139, 60);
            this.numberNodes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberNodes.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberNodes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberNodes.Name = "numberNodes";
            this.numberNodes.Size = new System.Drawing.Size(65, 22);
            this.numberNodes.TabIndex = 19;
            this.numberNodes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Кількість вершин: ";
            // 
            // DemoButton
            // 
            this.DemoButton.Location = new System.Drawing.Point(12, 91);
            this.DemoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DemoButton.Name = "DemoButton";
            this.DemoButton.Size = new System.Drawing.Size(181, 28);
            this.DemoButton.TabIndex = 0;
            this.DemoButton.Text = "Запропонувати граф";
            this.DemoButton.UseVisualStyleBackColor = true;
            this.DemoButton.Click += new System.EventHandler(this.DemoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Кількість ребер: ";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.summaryBox);
            this.groupBox8.Location = new System.Drawing.Point(844, 33);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Size = new System.Drawing.Size(388, 662);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Висновок";
            // 
            // summaryBox
            // 
            this.summaryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryBox.Location = new System.Drawing.Point(4, 19);
            this.summaryBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.ReadOnly = true;
            this.summaryBox.Size = new System.Drawing.Size(380, 639);
            this.summaryBox.TabIndex = 7;
            this.summaryBox.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 700);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1263, 747);
            this.MinimumSize = new System.Drawing.Size(1263, 747);
            this.Name = "MainWindow";
            this.Text = "Порівняння графів на еквівалентність";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGraphBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureGraphBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberEdges)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberNodes)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заполнениеГрафовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGraphs;
        private System.Windows.Forms.ToolStripMenuItem loadGraphs;
        private System.Windows.Forms.ToolStripMenuItem побудуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuildGraph1;
        private System.Windows.Forms.ToolStripMenuItem BuildGraph2;
        private System.Windows.Forms.ToolStripMenuItem інформаціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgram;
        private System.Windows.Forms.ToolStripMenuItem aboutGraph;
        private System.Windows.Forms.ToolStripMenuItem aboutGraph1;
        private System.Windows.Forms.ToolStripMenuItem aboutGraph2;
        private System.Windows.Forms.ToolStripMenuItem aboutAuthor;
        private System.Windows.Forms.RichTextBox FOBox;
        private System.Windows.Forms.PictureBox pictureGraphBox1;
        private System.Windows.Forms.ListBox listOfSubGraphBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureGraphBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox listOfSubGraphBox2;
        private System.Windows.Forms.NumericUpDown numberEdges;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown numberNodes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DemoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox summaryBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox IsDirectedEdges;
    }
}

