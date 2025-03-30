namespace SmartWarehouse_360
{
    partial class FormPostavshiki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPostavshiki));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBoxSearch = new ToolStripTextBox();
            toolStripSeparator2 = new ToolStripSeparator();
            dataGridViewNamePost = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            buttonUpdPost = new Button();
            buttonAddPost = new Button();
            buttonDelPoast = new Button();
            groupBox1 = new GroupBox();
            textBoxEmail = new TextBox();
            textBoxAccount = new TextBox();
            textBoxBIC = new TextBox();
            textBoxINN = new TextBox();
            textBoxActAddress = new TextBox();
            textBoxAddress = new TextBox();
            textBoxFIOPrad = new TextBox();
            textBoxNazPost = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            maskedTextBoxPhone = new MaskedTextBox();
            label5 = new Label();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNamePost).BeginInit();
            groupBox1.SuspendLayout();
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
            toolStrip1.Size = new Size(985, 27);
            toolStrip1.TabIndex = 5;
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
            toolStripTextBoxSearch.TextChanged += toolStripTextBox1_TextChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // dataGridViewNamePost
            // 
            dataGridViewNamePost.AllowUserToAddRows = false;
            dataGridViewNamePost.AllowUserToDeleteRows = false;
            dataGridViewNamePost.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNamePost.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNamePost.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1 });
            dataGridViewNamePost.Location = new Point(14, 42);
            dataGridViewNamePost.Margin = new Padding(5, 4, 5, 4);
            dataGridViewNamePost.Name = "dataGridViewNamePost";
            dataGridViewNamePost.ReadOnly = true;
            dataGridViewNamePost.RowHeadersWidth = 51;
            dataGridViewNamePost.Size = new Size(265, 556);
            dataGridViewNamePost.TabIndex = 13;
            dataGridViewNamePost.SelectionChanged += dataGridViewNamePost_SelectionChanged;
            dataGridViewNamePost.Click += dataGridViewNamePost_Click;
            // 
            // Column2
            // 
            Column2.HeaderText = "id";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Название поставщика";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // buttonUpdPost
            // 
            buttonUpdPost.Image = (Image)resources.GetObject("buttonUpdPost.Image");
            buttonUpdPost.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUpdPost.Location = new Point(642, 609);
            buttonUpdPost.Margin = new Padding(5, 4, 5, 4);
            buttonUpdPost.Name = "buttonUpdPost";
            buttonUpdPost.Size = new Size(195, 63);
            buttonUpdPost.TabIndex = 16;
            buttonUpdPost.Text = "                Редактировать              поставщика\r\n";
            buttonUpdPost.UseVisualStyleBackColor = true;
            buttonUpdPost.Click += buttonUpdPost_Click;
            // 
            // buttonAddPost
            // 
            buttonAddPost.Image = (Image)resources.GetObject("buttonAddPost.Image");
            buttonAddPost.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddPost.Location = new Point(436, 609);
            buttonAddPost.Margin = new Padding(5, 4, 5, 4);
            buttonAddPost.Name = "buttonAddPost";
            buttonAddPost.Size = new Size(197, 63);
            buttonAddPost.TabIndex = 15;
            buttonAddPost.Text = "                Добавить                     поставщика\r\n";
            buttonAddPost.UseVisualStyleBackColor = true;
            buttonAddPost.Click += buttonAddPost_Click;
            // 
            // buttonDelPoast
            // 
            buttonDelPoast.Image = (Image)resources.GetObject("buttonDelPoast.Image");
            buttonDelPoast.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelPoast.Location = new Point(42, 606);
            buttonDelPoast.Margin = new Padding(5, 4, 5, 4);
            buttonDelPoast.Name = "buttonDelPoast";
            buttonDelPoast.Size = new Size(187, 64);
            buttonDelPoast.TabIndex = 17;
            buttonDelPoast.Text = "                  Удалить                         поставщика\r\n";
            buttonDelPoast.UseVisualStyleBackColor = true;
            buttonDelPoast.Click += buttonDelPoast_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxAccount);
            groupBox1.Controls.Add(textBoxBIC);
            groupBox1.Controls.Add(textBoxINN);
            groupBox1.Controls.Add(textBoxActAddress);
            groupBox1.Controls.Add(textBoxAddress);
            groupBox1.Controls.Add(textBoxFIOPrad);
            groupBox1.Controls.Add(textBoxNazPost);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(maskedTextBoxPhone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(282, 42);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(694, 559);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация о поставщике";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Enabled = false;
            textBoxEmail.Location = new Point(238, 521);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.MaxLength = 255;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(436, 30);
            textBoxEmail.TabIndex = 29;
            // 
            // textBoxAccount
            // 
            textBoxAccount.Enabled = false;
            textBoxAccount.Location = new Point(238, 479);
            textBoxAccount.Margin = new Padding(3, 4, 3, 4);
            textBoxAccount.MaxLength = 20;
            textBoxAccount.Name = "textBoxAccount";
            textBoxAccount.Size = new Size(436, 30);
            textBoxAccount.TabIndex = 28;
            textBoxAccount.KeyPress += textBoxAccount_KeyPress;
            // 
            // textBoxBIC
            // 
            textBoxBIC.Enabled = false;
            textBoxBIC.Location = new Point(238, 435);
            textBoxBIC.Margin = new Padding(3, 4, 3, 4);
            textBoxBIC.MaxLength = 9;
            textBoxBIC.Name = "textBoxBIC";
            textBoxBIC.Size = new Size(436, 30);
            textBoxBIC.TabIndex = 27;
            textBoxBIC.KeyPress += textBoxBIC_KeyPress;
            // 
            // textBoxINN
            // 
            textBoxINN.Enabled = false;
            textBoxINN.Location = new Point(238, 393);
            textBoxINN.Margin = new Padding(3, 4, 3, 4);
            textBoxINN.MaxLength = 12;
            textBoxINN.Name = "textBoxINN";
            textBoxINN.Size = new Size(436, 30);
            textBoxINN.TabIndex = 26;
            textBoxINN.KeyPress += textBoxINN_KeyPress;
            // 
            // textBoxActAddress
            // 
            textBoxActAddress.Enabled = false;
            textBoxActAddress.Location = new Point(238, 270);
            textBoxActAddress.Margin = new Padding(3, 4, 3, 4);
            textBoxActAddress.MaxLength = 255;
            textBoxActAddress.Multiline = true;
            textBoxActAddress.Name = "textBoxActAddress";
            textBoxActAddress.Size = new Size(436, 115);
            textBoxActAddress.TabIndex = 25;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Enabled = false;
            textBoxAddress.Location = new Point(238, 178);
            textBoxAddress.Margin = new Padding(3, 4, 3, 4);
            textBoxAddress.MaxLength = 255;
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(436, 84);
            textBoxAddress.TabIndex = 24;
            // 
            // textBoxFIOPrad
            // 
            textBoxFIOPrad.Enabled = false;
            textBoxFIOPrad.Location = new Point(238, 93);
            textBoxFIOPrad.Margin = new Padding(3, 4, 3, 4);
            textBoxFIOPrad.MaxLength = 255;
            textBoxFIOPrad.Name = "textBoxFIOPrad";
            textBoxFIOPrad.Size = new Size(436, 30);
            textBoxFIOPrad.TabIndex = 22;
            // 
            // textBoxNazPost
            // 
            textBoxNazPost.Enabled = false;
            textBoxNazPost.Location = new Point(238, 31);
            textBoxNazPost.Margin = new Padding(3, 4, 3, 4);
            textBoxNazPost.MaxLength = 255;
            textBoxNazPost.Multiline = true;
            textBoxNazPost.Name = "textBoxNazPost";
            textBoxNazPost.Size = new Size(436, 54);
            textBoxNazPost.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 481);
            label10.Name = "label10";
            label10.Size = new Size(55, 24);
            label10.TabIndex = 20;
            label10.Text = "Счет*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 439);
            label9.Name = "label9";
            label9.Size = new Size(50, 24);
            label9.TabIndex = 19;
            label9.Text = "БИК*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 393);
            label8.Name = "label8";
            label8.Size = new Size(52, 24);
            label8.TabIndex = 18;
            label8.Text = "ИНН*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 524);
            label7.Name = "label7";
            label7.Size = new Size(52, 24);
            label7.TabIndex = 17;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 270);
            label6.Name = "label6";
            label6.Size = new Size(173, 24);
            label6.TabIndex = 16;
            label6.Text = "Фактический адрес*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 178);
            label4.Name = "label4";
            label4.Size = new Size(65, 24);
            label4.TabIndex = 15;
            label4.Text = "Адрес*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 93);
            label2.Name = "label2";
            label2.Size = new Size(182, 24);
            label2.TabIndex = 13;
            label2.Text = "ФИО представителя*";
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Enabled = false;
            maskedTextBoxPhone.Location = new Point(238, 137);
            maskedTextBoxPhone.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxPhone.Mask = "+7(999) 000-0000";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(436, 30);
            maskedTextBoxPhone.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 137);
            label5.Name = "label5";
            label5.Size = new Size(190, 24);
            label5.TabIndex = 11;
            label5.Text = "Телефон поставщика*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 34);
            label1.Name = "label1";
            label1.Size = new Size(195, 24);
            label1.TabIndex = 0;
            label1.Text = "Название поставщика*";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(0, 175, 100);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 678);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(985, 26);
            statusStrip1.TabIndex = 19;
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
            toolStripStatusLabel2.Margin = new Padding(700, 4, 0, 2);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(77, 20);
            toolStripStatusLabel2.Text = "дд.мм.гггг";
            toolStripStatusLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormPostavshiki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(54, 215, 146);
            ClientSize = new Size(985, 704);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Controls.Add(buttonDelPoast);
            Controls.Add(buttonUpdPost);
            Controls.Add(buttonAddPost);
            Controls.Add(dataGridViewNamePost);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximumSize = new Size(1003, 751);
            MinimumSize = new Size(1003, 751);
            Name = "FormPostavshiki";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поставщики";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNamePost).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button buttonUpdPost;
        private Button buttonAddPost;
        private Button buttonDelPoast;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        public TextBox textBoxEmail;
        public TextBox textBoxAccount;
        public TextBox textBoxBIC;
        public TextBox textBoxINN;
        public TextBox textBoxActAddress;
        public TextBox textBoxAddress;
        public TextBox textBoxFIOPrad;
        public TextBox textBoxNazPost;
        public MaskedTextBox maskedTextBoxPhone;
        public DataGridView dataGridViewNamePost;
    }
}