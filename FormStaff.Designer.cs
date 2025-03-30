namespace SmartWarehouse_360
{
    partial class FormStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaff));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBoxSearch = new ToolStripTextBox();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButtonAxp = new ToolStripButton();
            dataGridViewStaff = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            buttonDelStaff = new Button();
            buttonUpdStaff = new Button();
            buttonAddStaff = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(0, 175, 100);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, toolStripLabel1, toolStripTextBoxSearch, toolStripSeparator2, toolStripButtonAxp });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(829, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(75, 24);
            toolStripButton1.Text = "Назад";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Image = (Image)resources.GetObject("toolStripLabel1.Image");
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(165, 24);
            toolStripLabel1.Text = "Поиск по фамилии:";
            // 
            // toolStripTextBoxSearch
            // 
            toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            toolStripTextBoxSearch.Size = new Size(114, 27);
            toolStripTextBoxSearch.TextChanged += toolStripTextBox1_TextChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // toolStripButtonAxp
            // 
            toolStripButtonAxp.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAxp.Image = (Image)resources.GetObject("toolStripButtonAxp.Image");
            toolStripButtonAxp.ImageTransparentColor = Color.Magenta;
            toolStripButtonAxp.Name = "toolStripButtonAxp";
            toolStripButtonAxp.Size = new Size(29, 24);
            toolStripButtonAxp.Text = "Импорт в PDF";
            toolStripButtonAxp.Click += toolStripButtonAxp_Click_1;
            // 
            // dataGridViewStaff
            // 
            dataGridViewStaff.AllowUserToAddRows = false;
            dataGridViewStaff.AllowUserToDeleteRows = false;
            dataGridViewStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaff.Columns.AddRange(new DataGridViewColumn[] { Column6, Column1, Column2, Column3, Column4, Column5 });
            dataGridViewStaff.Location = new Point(12, 35);
            dataGridViewStaff.Margin = new Padding(3, 4, 3, 4);
            dataGridViewStaff.Name = "dataGridViewStaff";
            dataGridViewStaff.ReadOnly = true;
            dataGridViewStaff.RowHeadersWidth = 51;
            dataGridViewStaff.Size = new Size(805, 484);
            dataGridViewStaff.TabIndex = 8;
            // 
            // Column6
            // 
            Column6.HeaderText = "id";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Visible = false;
            Column6.Width = 51;
            // 
            // Column1
            // 
            Column1.HeaderText = "Фамилия";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 102;
            // 
            // Column2
            // 
            Column2.HeaderText = "Имя";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 68;
            // 
            // Column3
            // 
            Column3.HeaderText = "Отчество";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 101;
            // 
            // Column4
            // 
            Column4.HeaderText = "Должность";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 115;
            // 
            // Column5
            // 
            Column5.HeaderText = "Телефон";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 98;
            // 
            // buttonDelStaff
            // 
            buttonDelStaff.Image = (Image)resources.GetObject("buttonDelStaff.Image");
            buttonDelStaff.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelStaff.Location = new Point(506, 522);
            buttonDelStaff.Margin = new Padding(3, 4, 3, 4);
            buttonDelStaff.Name = "buttonDelStaff";
            buttonDelStaff.Size = new Size(187, 79);
            buttonDelStaff.TabIndex = 15;
            buttonDelStaff.Text = "                  Удалить                         сотрудника";
            buttonDelStaff.UseVisualStyleBackColor = true;
            buttonDelStaff.Click += buttonDelStaff_Click;
            // 
            // buttonUpdStaff
            // 
            buttonUpdStaff.Image = (Image)resources.GetObject("buttonUpdStaff.Image");
            buttonUpdStaff.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUpdStaff.Location = new Point(313, 522);
            buttonUpdStaff.Margin = new Padding(3, 4, 3, 4);
            buttonUpdStaff.Name = "buttonUpdStaff";
            buttonUpdStaff.Size = new Size(187, 79);
            buttonUpdStaff.TabIndex = 14;
            buttonUpdStaff.Text = "                Редактировать            сотрудника";
            buttonUpdStaff.UseVisualStyleBackColor = true;
            buttonUpdStaff.Click += buttonUpdStaff_Click;
            // 
            // buttonAddStaff
            // 
            buttonAddStaff.Image = (Image)resources.GetObject("buttonAddStaff.Image");
            buttonAddStaff.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddStaff.Location = new Point(120, 522);
            buttonAddStaff.Margin = new Padding(3, 4, 3, 4);
            buttonAddStaff.Name = "buttonAddStaff";
            buttonAddStaff.Size = new Size(187, 79);
            buttonAddStaff.TabIndex = 13;
            buttonAddStaff.Text = "                Добавить                     сотрудника";
            buttonAddStaff.UseVisualStyleBackColor = true;
            buttonAddStaff.Click += buttonAddStaff_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(0, 175, 100);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 605);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(829, 26);
            statusStrip1.TabIndex = 16;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(193, 20);
            toolStripStatusLabel1.Text = "Должность: Админ. склада";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Margin = new Padding(540, 4, 0, 2);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(77, 20);
            toolStripStatusLabel2.Text = "дд.мм.гггг";
            toolStripStatusLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 215, 146);
            ClientSize = new Size(829, 631);
            Controls.Add(statusStrip1);
            Controls.Add(buttonDelStaff);
            Controls.Add(buttonUpdStaff);
            Controls.Add(buttonAddStaff);
            Controls.Add(dataGridViewStaff);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(847, 678);
            MinimumSize = new Size(847, 678);
            Name = "FormStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сотрудники";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBoxSearch;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonAxp;
        private Button buttonDelStaff;
        private Button buttonUpdStaff;
        private Button buttonAddStaff;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        public DataGridView dataGridViewStaff;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}