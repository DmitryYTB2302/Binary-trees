namespace BinaryTree
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTree = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBypass = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.solution = new System.Windows.Forms.ToolStripMenuItem();
            this.Load = new System.Windows.Forms.ToolStripMenuItem();
            this.bypass = new System.Windows.Forms.ToolStripMenuItem();
            this.LNR = new System.Windows.Forms.ToolStripMenuItem();
            this.NLR = new System.Windows.Forms.ToolStripMenuItem();
            this.LRN = new System.Windows.Forms.ToolStripMenuItem();
            this.RNL = new System.Windows.Forms.ToolStripMenuItem();
            this.BFS = new System.Windows.Forms.ToolStripMenuItem();
            this.All = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTree);
            this.groupBox1.Location = new System.Drawing.Point(26, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 468);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дерево";
            // 
            // textBoxTree
            // 
            this.textBoxTree.Location = new System.Drawing.Point(19, 31);
            this.textBoxTree.Multiline = true;
            this.textBoxTree.Name = "textBoxTree";
            this.textBoxTree.Size = new System.Drawing.Size(393, 416);
            this.textBoxTree.TabIndex = 0;
            this.textBoxTree.TextChanged += new System.EventHandler(this.textBoxTree_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxBypass);
            this.groupBox2.Location = new System.Drawing.Point(488, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обходы";
            // 
            // textBoxBypass
            // 
            this.textBoxBypass.Location = new System.Drawing.Point(22, 31);
            this.textBoxBypass.Multiline = true;
            this.textBoxBypass.Name = "textBoxBypass";
            this.textBoxBypass.Size = new System.Drawing.Size(471, 167);
            this.textBoxBypass.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Controls.Add(this.textBoxSearch);
            this.groupBox3.Controls.Add(this.textBoxKey);
            this.groupBox3.Location = new System.Drawing.Point(488, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(514, 229);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск ключа";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(374, 21);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(119, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(22, 88);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(471, 120);
            this.textBoxSearch.TabIndex = 3;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(22, 44);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(326, 22);
            this.textBoxKey.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solution,
            this.Close});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // solution
            // 
            this.solution.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Load,
            this.bypass});
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(155, 24);
            this.solution.Text = "Обработка данных";
            // 
            // Load
            // 
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(217, 26);
            this.Load.Text = "Загрузить данные";
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // bypass
            // 
            this.bypass.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LNR,
            this.NLR,
            this.LRN,
            this.RNL,
            this.BFS,
            this.All});
            this.bypass.Name = "bypass";
            this.bypass.Size = new System.Drawing.Size(217, 26);
            this.bypass.Text = "Выполнить обход";
            // 
            // LNR
            // 
            this.LNR.Name = "LNR";
            this.LNR.Size = new System.Drawing.Size(288, 26);
            this.LNR.Text = "Симметричный метод - LNR";
            this.LNR.Click += new System.EventHandler(this.LNR_Click);
            // 
            // NLR
            // 
            this.NLR.Name = "NLR";
            this.NLR.Size = new System.Drawing.Size(288, 26);
            this.NLR.Text = "Прямой метод - NLR";
            this.NLR.Click += new System.EventHandler(this.NLR_Click);
            // 
            // LRN
            // 
            this.LRN.Name = "LRN";
            this.LRN.Size = new System.Drawing.Size(288, 26);
            this.LRN.Text = "Обратный метод - LRN";
            this.LRN.Click += new System.EventHandler(this.LRN_Click);
            // 
            // RNL
            // 
            this.RNL.Name = "RNL";
            this.RNL.Size = new System.Drawing.Size(288, 26);
            this.RNL.Text = "Метод справа-налево - RNL";
            this.RNL.Click += new System.EventHandler(this.RNL_Click);
            // 
            // BFS
            // 
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(288, 26);
            this.BFS.Text = "Обход в ширину - BFS ";
            this.BFS.Click += new System.EventHandler(this.BFS_Click);
            // 
            // All
            // 
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(288, 26);
            this.All.Text = "Все...";
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // Close
            // 
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(67, 24);
            this.Close.Text = "Выход";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 557);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Бинарные деревья";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTree;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxBypass;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem solution;
        private System.Windows.Forms.ToolStripMenuItem Load;
        private System.Windows.Forms.ToolStripMenuItem bypass;
        private System.Windows.Forms.ToolStripMenuItem LNR;
        private System.Windows.Forms.ToolStripMenuItem NLR;
        private System.Windows.Forms.ToolStripMenuItem LRN;
        private System.Windows.Forms.ToolStripMenuItem RNL;
        private System.Windows.Forms.ToolStripMenuItem BFS;
        private System.Windows.Forms.ToolStripMenuItem All;
        private System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

