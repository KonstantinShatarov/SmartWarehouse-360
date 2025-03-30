namespace SmartWarehouse_360
{
    partial class FormAssortment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAssortment));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBoxSearch = new ToolStripTextBox();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            dataGridViewAssort = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            buttonDelProd = new Button();
            buttonUpdProd = new Button();
            buttonAddProd = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssort).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(0, 175, 100);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, toolStripLabel1, toolStripTextBoxSearch, toolStripSeparator2, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1115, 27);
            toolStrip1.TabIndex = 4;
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
            toolStripLabel1.Size = new Size(75, 24);
            toolStripLabel1.Text = "Поиск:";
            // 
            // toolStripTextBoxSearch
            // 
            toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            toolStripTextBoxSearch.Size = new Size(114, 27);
            toolStripTextBoxSearch.TextChanged += toolStripTextBoxSearch_TextChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "Импорт в PDF";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // dataGridViewAssort
            // 
            dataGridViewAssort.AllowUserToAddRows = false;
            dataGridViewAssort.AllowUserToDeleteRows = false;
            dataGridViewAssort.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAssort.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAssort.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, Column2, Column4, Column7, Column5, Column6 });
            dataGridViewAssort.Location = new Point(14, 39);
            dataGridViewAssort.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAssort.MultiSelect = false;
            dataGridViewAssort.Name = "dataGridViewAssort";
            dataGridViewAssort.ReadOnly = true;
            dataGridViewAssort.RowHeadersWidth = 51;
            dataGridViewAssort.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAssort.Size = new Size(1089, 573);
            dataGridViewAssort.TabIndex = 5;
            // 
            // Column3
            // 
            Column3.HeaderText = "id_prod";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Название товара";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Артикул";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ед. измерения";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Категория товара";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Описание";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Доп. информация";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(0, 175, 100);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 704);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1115, 26);
            statusStrip1.TabIndex = 8;
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
            toolStripStatusLabel2.Margin = new Padding(830, 4, 0, 2);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(77, 20);
            toolStripStatusLabel2.Text = "дд.мм.гггг";
            toolStripStatusLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonDelProd
            // 
            buttonDelProd.Image = (Image)resources.GetObject("buttonDelProd.Image");
            buttonDelProd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelProd.Location = new Point(704, 618);
            buttonDelProd.Margin = new Padding(3, 4, 3, 4);
            buttonDelProd.Name = "buttonDelProd";
            buttonDelProd.Size = new Size(213, 79);
            buttonDelProd.TabIndex = 18;
            buttonDelProd.Text = "          Удалить товар";
            buttonDelProd.UseVisualStyleBackColor = true;
            buttonDelProd.Click += buttonDelProd_Click;
            // 
            // buttonUpdProd
            // 
            buttonUpdProd.Image = (Image)resources.GetObject("buttonUpdProd.Image");
            buttonUpdProd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUpdProd.Location = new Point(471, 618);
            buttonUpdProd.Margin = new Padding(3, 4, 3, 4);
            buttonUpdProd.Name = "buttonUpdProd";
            buttonUpdProd.Size = new Size(227, 79);
            buttonUpdProd.TabIndex = 17;
            buttonUpdProd.Text = "        Редактировать товар";
            buttonUpdProd.UseVisualStyleBackColor = true;
            buttonUpdProd.Click += buttonUpdProd_Click;
            // 
            // buttonAddProd
            // 
            buttonAddProd.Image = (Image)resources.GetObject("buttonAddProd.Image");
            buttonAddProd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddProd.Location = new Point(262, 618);
            buttonAddProd.Margin = new Padding(3, 4, 3, 4);
            buttonAddProd.Name = "buttonAddProd";
            buttonAddProd.Size = new Size(203, 79);
            buttonAddProd.TabIndex = 16;
            buttonAddProd.Text = "         Добавить товар";
            buttonAddProd.UseVisualStyleBackColor = true;
            buttonAddProd.Click += buttonAddProd_Click;
            // 
            // FormAssortment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 215, 146);
            ClientSize = new Size(1115, 730);
            Controls.Add(buttonDelProd);
            Controls.Add(buttonUpdProd);
            Controls.Add(buttonAddProd);
            Controls.Add(statusStrip1);
            Controls.Add(dataGridViewAssort);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1133, 777);
            MinimumSize = new Size(1133, 777);
            Name = "FormAssortment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ассортимент";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssort).EndInit();
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
        private ToolStripButton toolStripButton2;
        private DataGridView dataGridViewAssort;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Button buttonDelProd;
        private Button buttonUpdProd;
        private Button buttonAddProd;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}