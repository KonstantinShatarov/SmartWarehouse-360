namespace SmartWarehouse_360
{
    partial class FormProductCategories
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductCategories));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            dataGridViewCatProd = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            добавитьКатегориюToolStripMenuItem = new ToolStripMenuItem();
            редактироватьКатегориюToolStripMenuItem = new ToolStripMenuItem();
            удалитьКатегориюToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCatProd).BeginInit();
            contextMenuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(0, 175, 100);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(749, 27);
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
            // dataGridViewCatProd
            // 
            dataGridViewCatProd.AllowUserToAddRows = false;
            dataGridViewCatProd.AllowUserToDeleteRows = false;
            dataGridViewCatProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCatProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCatProd.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, Column2 });
            dataGridViewCatProd.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCatProd.Location = new Point(12, 31);
            dataGridViewCatProd.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCatProd.Name = "dataGridViewCatProd";
            dataGridViewCatProd.ReadOnly = true;
            dataGridViewCatProd.RowHeadersWidth = 51;
            dataGridViewCatProd.Size = new Size(725, 300);
            dataGridViewCatProd.TabIndex = 5;
            // 
            // Column3
            // 
            Column3.HeaderText = "id";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            Column3.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Название категории";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 165;
            // 
            // Column2
            // 
            Column2.HeaderText = "Описание категории";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 167;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { добавитьКатегориюToolStripMenuItem, редактироватьКатегориюToolStripMenuItem, удалитьКатегориюToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(263, 82);
            // 
            // добавитьКатегориюToolStripMenuItem
            // 
            добавитьКатегориюToolStripMenuItem.Image = (Image)resources.GetObject("добавитьКатегориюToolStripMenuItem.Image");
            добавитьКатегориюToolStripMenuItem.Name = "добавитьКатегориюToolStripMenuItem";
            добавитьКатегориюToolStripMenuItem.Size = new Size(262, 26);
            добавитьКатегориюToolStripMenuItem.Text = "Добавить категорию";
            добавитьКатегориюToolStripMenuItem.Click += добавитьКатегориюToolStripMenuItem_Click;
            // 
            // редактироватьКатегориюToolStripMenuItem
            // 
            редактироватьКатегориюToolStripMenuItem.Image = (Image)resources.GetObject("редактироватьКатегориюToolStripMenuItem.Image");
            редактироватьКатегориюToolStripMenuItem.Name = "редактироватьКатегориюToolStripMenuItem";
            редактироватьКатегориюToolStripMenuItem.Size = new Size(262, 26);
            редактироватьКатегориюToolStripMenuItem.Text = "Редактировать категорию";
            редактироватьКатегориюToolStripMenuItem.Click += редактироватьКатегориюToolStripMenuItem_Click;
            // 
            // удалитьКатегориюToolStripMenuItem
            // 
            удалитьКатегориюToolStripMenuItem.Image = (Image)resources.GetObject("удалитьКатегориюToolStripMenuItem.Image");
            удалитьКатегориюToolStripMenuItem.Name = "удалитьКатегориюToolStripMenuItem";
            удалитьКатегориюToolStripMenuItem.Size = new Size(262, 26);
            удалитьКатегориюToolStripMenuItem.Text = "Удалить категорию";
            удалитьКатегориюToolStripMenuItem.Click += удалитьКатегориюToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(0, 175, 100);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 340);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(749, 26);
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
            toolStripStatusLabel2.Margin = new Padding(455, 4, 0, 2);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(77, 20);
            toolStripStatusLabel2.Text = "дд.мм.гггг";
            toolStripStatusLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormProductCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 215, 146);
            ClientSize = new Size(749, 366);
            Controls.Add(statusStrip1);
            Controls.Add(dataGridViewCatProd);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(767, 413);
            MinimumSize = new Size(767, 413);
            Name = "FormProductCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Категории товаров";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCatProd).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem добавитьКатегориюToolStripMenuItem;
        private ToolStripMenuItem редактироватьКатегориюToolStripMenuItem;
        private ToolStripMenuItem удалитьКатегориюToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        public DataGridView dataGridViewCatProd;
    }
}