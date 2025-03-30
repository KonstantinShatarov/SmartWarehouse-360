namespace SmartWarehouse_360
{
    partial class FormInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoice));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBoxSearch = new ToolStripTextBox();
            toolStripSeparator2 = new ToolStripSeparator();
            buttonDelInvoice = new Button();
            buttonUpdInvoice = new Button();
            buttonAddInvoice = new Button();
            dataGridViewInvoice = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label9 = new Label();
            textBoxDescr = new TextBox();
            textBoxStaff = new TextBox();
            maskedTextBoxDateInv = new MaskedTextBox();
            textBoxPostav = new TextBox();
            textBoxNumbInv = new TextBox();
            textBoxObshSumm = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            dataGridViewProduct = new DataGridView();
            Column10 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            buttonDelPoz = new Button();
            buttonAddPoz = new Button();
            buttonUpdPoz = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(0, 175, 100);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, toolStripLabel1, toolStripTextBoxSearch, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1537, 27);
            toolStrip1.TabIndex = 3;
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
            // buttonDelInvoice
            // 
            buttonDelInvoice.Image = (Image)resources.GetObject("buttonDelInvoice.Image");
            buttonDelInvoice.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelInvoice.Location = new Point(414, 22);
            buttonDelInvoice.Margin = new Padding(3, 4, 3, 4);
            buttonDelInvoice.Name = "buttonDelInvoice";
            buttonDelInvoice.Size = new Size(187, 79);
            buttonDelInvoice.TabIndex = 11;
            buttonDelInvoice.Text = "                  Удалить                         накладную";
            buttonDelInvoice.UseVisualStyleBackColor = true;
            buttonDelInvoice.Click += buttonDelInvoice_Click;
            // 
            // buttonUpdInvoice
            // 
            buttonUpdInvoice.Image = (Image)resources.GetObject("buttonUpdInvoice.Image");
            buttonUpdInvoice.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUpdInvoice.Location = new Point(210, 22);
            buttonUpdInvoice.Margin = new Padding(3, 4, 3, 4);
            buttonUpdInvoice.Name = "buttonUpdInvoice";
            buttonUpdInvoice.Size = new Size(198, 79);
            buttonUpdInvoice.TabIndex = 10;
            buttonUpdInvoice.Text = "          Редактировать           накладную";
            buttonUpdInvoice.UseVisualStyleBackColor = true;
            buttonUpdInvoice.Click += buttonUpdInvoice_Click;
            // 
            // buttonAddInvoice
            // 
            buttonAddInvoice.Image = (Image)resources.GetObject("buttonAddInvoice.Image");
            buttonAddInvoice.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddInvoice.Location = new Point(6, 22);
            buttonAddInvoice.Margin = new Padding(3, 4, 3, 4);
            buttonAddInvoice.Name = "buttonAddInvoice";
            buttonAddInvoice.Size = new Size(198, 79);
            buttonAddInvoice.TabIndex = 9;
            buttonAddInvoice.Text = "       Добавить           накладную";
            buttonAddInvoice.UseVisualStyleBackColor = true;
            buttonAddInvoice.Click += buttonAddInvoice_Click;
            // 
            // dataGridViewInvoice
            // 
            dataGridViewInvoice.AllowUserToAddRows = false;
            dataGridViewInvoice.AllowUserToDeleteRows = false;
            dataGridViewInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoice.Columns.AddRange(new DataGridViewColumn[] { Column9, Column1 });
            dataGridViewInvoice.Location = new Point(5, 47);
            dataGridViewInvoice.Margin = new Padding(3, 4, 3, 4);
            dataGridViewInvoice.Name = "dataGridViewInvoice";
            dataGridViewInvoice.ReadOnly = true;
            dataGridViewInvoice.RowHeadersWidth = 51;
            dataGridViewInvoice.Size = new Size(207, 522);
            dataGridViewInvoice.TabIndex = 12;
            dataGridViewInvoice.CellClick += dataGridViewInvoice_CellClick;
            dataGridViewInvoice.SelectionChanged += dataGridViewInvoice_SelectionChanged;
            // 
            // Column9
            // 
            Column9.HeaderText = "id";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Номер накладной";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold);
            tabControl1.Location = new Point(218, 47);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1268, 526);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(textBoxDescr);
            tabPage1.Controls.Add(textBoxStaff);
            tabPage1.Controls.Add(maskedTextBoxDateInv);
            tabPage1.Controls.Add(textBoxPostav);
            tabPage1.Controls.Add(textBoxNumbInv);
            tabPage1.Controls.Add(textBoxObshSumm);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 36);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1260, 486);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Информация накладной";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(257, 309);
            label9.Name = "label9";
            label9.Size = new Size(175, 54);
            label9.TabIndex = 42;
            label9.Text = "Дополнительная \r\nинформация";
            // 
            // textBoxDescr
            // 
            textBoxDescr.Enabled = false;
            textBoxDescr.Location = new Point(555, 309);
            textBoxDescr.Multiline = true;
            textBoxDescr.Name = "textBoxDescr";
            textBoxDescr.Size = new Size(355, 122);
            textBoxDescr.TabIndex = 39;
            // 
            // textBoxStaff
            // 
            textBoxStaff.Enabled = false;
            textBoxStaff.Location = new Point(555, 262);
            textBoxStaff.Name = "textBoxStaff";
            textBoxStaff.Size = new Size(355, 34);
            textBoxStaff.TabIndex = 14;
            // 
            // maskedTextBoxDateInv
            // 
            maskedTextBoxDateInv.Enabled = false;
            maskedTextBoxDateInv.Location = new Point(555, 162);
            maskedTextBoxDateInv.Mask = "00/00/0000";
            maskedTextBoxDateInv.Name = "maskedTextBoxDateInv";
            maskedTextBoxDateInv.Size = new Size(355, 34);
            maskedTextBoxDateInv.TabIndex = 13;
            maskedTextBoxDateInv.ValidatingType = typeof(DateTime);
            // 
            // textBoxPostav
            // 
            textBoxPostav.Enabled = false;
            textBoxPostav.Location = new Point(555, 114);
            textBoxPostav.Margin = new Padding(3, 4, 3, 4);
            textBoxPostav.Name = "textBoxPostav";
            textBoxPostav.Size = new Size(355, 34);
            textBoxPostav.TabIndex = 10;
            // 
            // textBoxNumbInv
            // 
            textBoxNumbInv.Enabled = false;
            textBoxNumbInv.Location = new Point(555, 66);
            textBoxNumbInv.Margin = new Padding(3, 4, 3, 4);
            textBoxNumbInv.Name = "textBoxNumbInv";
            textBoxNumbInv.Size = new Size(355, 34);
            textBoxNumbInv.TabIndex = 10;
            // 
            // textBoxObshSumm
            // 
            textBoxObshSumm.Enabled = false;
            textBoxObshSumm.Location = new Point(555, 211);
            textBoxObshSumm.Margin = new Padding(3, 4, 3, 4);
            textBoxObshSumm.Name = "textBoxObshSumm";
            textBoxObshSumm.Size = new Size(355, 34);
            textBoxObshSumm.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(257, 262);
            label6.Name = "label6";
            label6.Size = new Size(285, 27);
            label6.TabIndex = 5;
            label6.Text = "Принял/проверил сотрудник";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 211);
            label3.Name = "label3";
            label3.Size = new Size(244, 27);
            label3.TabIndex = 2;
            label3.Text = "Общая сумма накладной";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 117);
            label4.Name = "label4";
            label4.Size = new Size(117, 27);
            label4.TabIndex = 0;
            label4.Text = "Поставщик";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 162);
            label2.Name = "label2";
            label2.Size = new Size(158, 27);
            label2.TabIndex = 1;
            label2.Text = "Дата накладной";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 66);
            label1.Name = "label1";
            label1.Size = new Size(178, 27);
            label1.TabIndex = 0;
            label1.Text = "Номер накладной";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewProduct);
            tabPage2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabPage2.Location = new Point(4, 36);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1260, 486);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Позиции накладной";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AllowUserToAddRows = false;
            dataGridViewProduct.AllowUserToDeleteRows = false;
            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Columns.AddRange(new DataGridViewColumn[] { Column10, Column2, Column3, Column6, Column4, Column5, Column7, Column8 });
            dataGridViewProduct.Location = new Point(0, 0);
            dataGridViewProduct.Margin = new Padding(3, 4, 3, 4);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.ReadOnly = true;
            dataGridViewProduct.RowHeadersWidth = 51;
            dataGridViewProduct.Size = new Size(1264, 486);
            dataGridViewProduct.TabIndex = 0;
            // 
            // Column10
            // 
            Column10.HeaderText = "id";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Visible = false;
            Column10.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Название товара";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 155;
            // 
            // Column3
            // 
            Column3.HeaderText = "Артикул";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 101;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ед. измерения";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 138;
            // 
            // Column4
            // 
            Column4.HeaderText = "Цена за ед. товара";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 123;
            // 
            // Column5
            // 
            Column5.HeaderText = "Количество товара";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 171;
            // 
            // Column7
            // 
            Column7.HeaderText = "Общая стоимость позиции";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 223;
            // 
            // Column8
            // 
            Column8.HeaderText = "Категория товара";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 159;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAddInvoice);
            groupBox1.Controls.Add(buttonUpdInvoice);
            groupBox1.Controls.Add(buttonDelInvoice);
            groupBox1.Location = new Point(22, 576);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(614, 110);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonDelPoz);
            groupBox2.Controls.Add(buttonAddPoz);
            groupBox2.Controls.Add(buttonUpdPoz);
            groupBox2.Location = new Point(857, 576);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(611, 110);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // buttonDelPoz
            // 
            buttonDelPoz.Image = (Image)resources.GetObject("buttonDelPoz.Image");
            buttonDelPoz.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelPoz.Location = new Point(414, 24);
            buttonDelPoz.Margin = new Padding(3, 4, 3, 4);
            buttonDelPoz.Name = "buttonDelPoz";
            buttonDelPoz.Size = new Size(187, 79);
            buttonDelPoz.TabIndex = 12;
            buttonDelPoz.Text = "                  Удалить                      позицию";
            buttonDelPoz.UseVisualStyleBackColor = true;
            buttonDelPoz.Click += buttonDelPoz_Click;
            // 
            // buttonAddPoz
            // 
            buttonAddPoz.Image = (Image)resources.GetObject("buttonAddPoz.Image");
            buttonAddPoz.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddPoz.Location = new Point(6, 24);
            buttonAddPoz.Margin = new Padding(3, 4, 3, 4);
            buttonAddPoz.Name = "buttonAddPoz";
            buttonAddPoz.Size = new Size(198, 79);
            buttonAddPoz.TabIndex = 9;
            buttonAddPoz.Text = "          Добавить позиции \r\n        в накладную";
            buttonAddPoz.UseVisualStyleBackColor = true;
            buttonAddPoz.Click += buttonAddPoz_Click;
            // 
            // buttonUpdPoz
            // 
            buttonUpdPoz.Image = (Image)resources.GetObject("buttonUpdPoz.Image");
            buttonUpdPoz.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUpdPoz.Location = new Point(210, 24);
            buttonUpdPoz.Margin = new Padding(3, 4, 3, 4);
            buttonUpdPoz.Name = "buttonUpdPoz";
            buttonUpdPoz.Size = new Size(198, 79);
            buttonUpdPoz.TabIndex = 10;
            buttonUpdPoz.Text = "          Редактировать  позиции \r\n     в накладной";
            buttonUpdPoz.UseVisualStyleBackColor = true;
            buttonUpdPoz.Click += buttonUpdPoz_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(0, 175, 100);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 694);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1537, 26);
            statusStrip1.TabIndex = 19;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(253, 20);
            toolStripStatusLabel1.Text = "Должность: Администратор склада";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Margin = new Padding(1180, 4, 0, 2);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(77, 20);
            toolStripStatusLabel2.Text = "дд.мм.гггг";
            toolStripStatusLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 215, 146);
            ClientSize = new Size(1537, 720);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(tabControl1);
            Controls.Add(dataGridViewInvoice);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1555, 767);
            MinimumSize = new Size(1555, 767);
            Name = "FormInvoice";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Накладные";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
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
        private Button buttonDelInvoice;
        private Button buttonUpdInvoice;
        private Button buttonAddInvoice;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonAddPoz;
        private Button buttonUpdPoz;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column1;
        public DataGridView dataGridViewInvoice;
        public TextBox textBoxNumbInv;
        public TextBox textBoxObshSumm;
        public MaskedTextBox maskedTextBoxDateInv;
        private TextBox textBoxStaff;
        public DataGridView dataGridViewProduct;
        public TextBox textBoxPostav;
        private Label label4;
        private Label label9;
        public TextBox textBoxDescr;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button buttonDelPoz;
    }
}