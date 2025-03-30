namespace SmartWarehouse_360
{
    partial class FormAddUpdPostav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUpdPostav));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            textBoxEmailD = new TextBox();
            textBoxAccD = new TextBox();
            textBoxBICD = new TextBox();
            textBoxINND = new TextBox();
            textBoxActAddr = new TextBox();
            textBoxAddr = new TextBox();
            textBoxFIO = new TextBox();
            textBoxName = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            maskedTextBoxPhoneD = new MaskedTextBox();
            label5 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            labelINFOPost = new Label();
            buttonCencel = new Button();
            buttonSave = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(103, 79);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(667, 496);
            panel1.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(textBoxEmailD);
            groupBox1.Controls.Add(textBoxAccD);
            groupBox1.Controls.Add(textBoxBICD);
            groupBox1.Controls.Add(textBoxINND);
            groupBox1.Controls.Add(textBoxActAddr);
            groupBox1.Controls.Add(textBoxAddr);
            groupBox1.Controls.Add(textBoxFIO);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(maskedTextBoxPhoneD);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(2, 0);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(661, 496);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация о поставщике";
            // 
            // textBoxEmailD
            // 
            textBoxEmailD.Location = new Point(218, 424);
            textBoxEmailD.Margin = new Padding(3, 4, 3, 4);
            textBoxEmailD.MaxLength = 255;
            textBoxEmailD.Name = "textBoxEmailD";
            textBoxEmailD.Size = new Size(418, 30);
            textBoxEmailD.TabIndex = 29;
            // 
            // textBoxAccD
            // 
            textBoxAccD.Location = new Point(218, 386);
            textBoxAccD.Margin = new Padding(3, 4, 3, 4);
            textBoxAccD.MaxLength = 20;
            textBoxAccD.Name = "textBoxAccD";
            textBoxAccD.Size = new Size(418, 30);
            textBoxAccD.TabIndex = 28;
            textBoxAccD.KeyPress += textBoxAccD_KeyPress;
            // 
            // textBoxBICD
            // 
            textBoxBICD.Location = new Point(218, 348);
            textBoxBICD.Margin = new Padding(3, 4, 3, 4);
            textBoxBICD.MaxLength = 9;
            textBoxBICD.Name = "textBoxBICD";
            textBoxBICD.Size = new Size(418, 30);
            textBoxBICD.TabIndex = 27;
            textBoxBICD.KeyPress += textBoxBICD_KeyPress;
            // 
            // textBoxINND
            // 
            textBoxINND.Location = new Point(218, 310);
            textBoxINND.Margin = new Padding(3, 4, 3, 4);
            textBoxINND.MaxLength = 12;
            textBoxINND.Name = "textBoxINND";
            textBoxINND.Size = new Size(418, 30);
            textBoxINND.TabIndex = 26;
            textBoxINND.KeyPress += textBoxINND_KeyPress;
            // 
            // textBoxActAddr
            // 
            textBoxActAddr.Location = new Point(218, 229);
            textBoxActAddr.Margin = new Padding(3, 4, 3, 4);
            textBoxActAddr.MaxLength = 255;
            textBoxActAddr.Multiline = true;
            textBoxActAddr.Name = "textBoxActAddr";
            textBoxActAddr.Size = new Size(418, 73);
            textBoxActAddr.TabIndex = 25;
            // 
            // textBoxAddr
            // 
            textBoxAddr.Location = new Point(218, 174);
            textBoxAddr.Margin = new Padding(3, 4, 3, 4);
            textBoxAddr.MaxLength = 255;
            textBoxAddr.Multiline = true;
            textBoxAddr.Name = "textBoxAddr";
            textBoxAddr.Size = new Size(418, 47);
            textBoxAddr.TabIndex = 24;
            // 
            // textBoxFIO
            // 
            textBoxFIO.Location = new Point(218, 87);
            textBoxFIO.Margin = new Padding(3, 4, 3, 4);
            textBoxFIO.MaxLength = 255;
            textBoxFIO.Name = "textBoxFIO";
            textBoxFIO.Size = new Size(418, 30);
            textBoxFIO.TabIndex = 22;
            textBoxFIO.KeyPress += textBoxFIO_KeyPress;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(218, 44);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.MaxLength = 255;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(418, 30);
            textBoxName.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 386);
            label10.Name = "label10";
            label10.Size = new Size(55, 24);
            label10.TabIndex = 20;
            label10.Text = "Счет*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 348);
            label9.Name = "label9";
            label9.Size = new Size(50, 24);
            label9.TabIndex = 19;
            label9.Text = "БИК*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 310);
            label8.Name = "label8";
            label8.Size = new Size(52, 24);
            label8.TabIndex = 18;
            label8.Text = "ИНН*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 424);
            label7.Name = "label7";
            label7.Size = new Size(58, 24);
            label7.TabIndex = 17;
            label7.Text = "Email*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 232);
            label6.Name = "label6";
            label6.Size = new Size(173, 24);
            label6.TabIndex = 16;
            label6.Text = "Фактический адрес*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 174);
            label4.Name = "label4";
            label4.Size = new Size(65, 24);
            label4.TabIndex = 15;
            label4.Text = "Адрес*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 87);
            label2.Name = "label2";
            label2.Size = new Size(182, 24);
            label2.TabIndex = 13;
            label2.Text = "ФИО представителя*";
            // 
            // maskedTextBoxPhoneD
            // 
            maskedTextBoxPhoneD.Location = new Point(218, 131);
            maskedTextBoxPhoneD.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxPhoneD.Mask = "+7(999) 000-0000";
            maskedTextBoxPhoneD.Name = "maskedTextBoxPhoneD";
            maskedTextBoxPhoneD.Size = new Size(418, 30);
            maskedTextBoxPhoneD.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 137);
            label5.Name = "label5";
            label5.Size = new Size(190, 24);
            label5.TabIndex = 11;
            label5.Text = "Телефон поставщика*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 44);
            label1.Name = "label1";
            label1.Size = new Size(195, 24);
            label1.TabIndex = 0;
            label1.Text = "Название поставщика*";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 175, 100);
            panel2.Controls.Add(labelINFOPost);
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(5, 7, 5, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 67);
            panel2.TabIndex = 20;
            // 
            // labelINFOPost
            // 
            labelINFOPost.AutoSize = true;
            labelINFOPost.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelINFOPost.Location = new Point(25, 23);
            labelINFOPost.Name = "labelINFOPost";
            labelINFOPost.Size = new Size(0, 29);
            labelINFOPost.TabIndex = 0;
            // 
            // buttonCencel
            // 
            buttonCencel.Image = (Image)resources.GetObject("buttonCencel.Image");
            buttonCencel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCencel.Location = new Point(463, 583);
            buttonCencel.Margin = new Padding(3, 4, 3, 4);
            buttonCencel.Name = "buttonCencel";
            buttonCencel.Size = new Size(201, 67);
            buttonCencel.TabIndex = 22;
            buttonCencel.Text = "         Отмена";
            buttonCencel.UseVisualStyleBackColor = true;
            buttonCencel.Click += button2_Click;
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(234, 583);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(201, 67);
            buttonSave.TabIndex = 21;
            buttonSave.Text = "         Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += button1_Click;
            // 
            // FormAddUpdPostav
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 215, 146);
            ClientSize = new Size(842, 655);
            Controls.Add(buttonCencel);
            Controls.Add(buttonSave);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(860, 702);
            MinimumSize = new Size(860, 702);
            Name = "FormAddUpdPostav";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label1;
        private Panel panel2;
        public Label labelINFOPost;
        private Button buttonCencel;
        private Button buttonSave;
        public MaskedTextBox maskedTextBoxPhoneD;
        public TextBox textBoxEmailD;
        public TextBox textBoxAccD;
        public TextBox textBoxBICD;
        public TextBox textBoxINND;
        public TextBox textBoxActAddr;
        public TextBox textBoxAddr;
        public TextBox textBoxFIO;
        public TextBox textBoxName;
    }
}