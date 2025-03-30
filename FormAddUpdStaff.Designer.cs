namespace SmartWarehouse_360
{
    partial class FormAddUpdStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUpdStaff));
            panel1 = new Panel();
            labelINFOStaff = new Label();
            groupBox1 = new GroupBox();
            maskedTextBoxPhone = new MaskedTextBox();
            label5 = new Label();
            textBoxPost = new TextBox();
            label4 = new Label();
            textBoxPatronymic = new TextBox();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonSave = new Button();
            button2 = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 175, 100);
            panel1.Controls.Add(labelINFOStaff);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 43);
            panel1.TabIndex = 0;
            // 
            // labelINFOStaff
            // 
            labelINFOStaff.AutoSize = true;
            labelINFOStaff.Location = new Point(56, 9);
            labelINFOStaff.Name = "labelINFOStaff";
            labelINFOStaff.Size = new Size(0, 24);
            labelINFOStaff.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBoxPhone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxPost);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxPatronymic);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(textBoxSurname);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 208);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Location = new Point(169, 169);
            maskedTextBoxPhone.Mask = "+7(000) 000-0000";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(200, 30);
            maskedTextBoxPhone.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 169);
            label5.Name = "label5";
            label5.Size = new Size(85, 24);
            label5.TabIndex = 9;
            label5.Text = "Телефон*";
            // 
            // textBoxPost
            // 
            textBoxPost.Location = new Point(169, 133);
            textBoxPost.Name = "textBoxPost";
            textBoxPost.Size = new Size(200, 30);
            textBoxPost.TabIndex = 7;
            textBoxPost.KeyPress += textBoxPost_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 133);
            label4.Name = "label4";
            label4.Size = new Size(100, 24);
            label4.TabIndex = 6;
            label4.Text = "Должность*";
            // 
            // textBoxPatronymic
            // 
            textBoxPatronymic.Location = new Point(169, 97);
            textBoxPatronymic.Name = "textBoxPatronymic";
            textBoxPatronymic.Size = new Size(200, 30);
            textBoxPatronymic.TabIndex = 5;
            textBoxPatronymic.KeyPress += textBoxPatronymic_KeyPress;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(169, 62);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 30);
            textBoxName.TabIndex = 4;
            textBoxName.KeyPress += textBoxName_KeyPress;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(169, 26);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(200, 30);
            textBoxSurname.TabIndex = 3;
            textBoxSurname.KeyPress += textBoxSurname_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 97);
            label3.Name = "label3";
            label3.Size = new Size(83, 24);
            label3.TabIndex = 2;
            label3.Text = "Отчество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 62);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 1;
            label2.Text = "Имя*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 26);
            label1.Name = "label1";
            label1.Size = new Size(85, 24);
            label1.TabIndex = 0;
            label1.Text = "Фамилия*";
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(43, 258);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(156, 51);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "         Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(210, 258);
            button2.Name = "button2";
            button2.Size = new Size(156, 51);
            button2.TabIndex = 3;
            button2.Text = "         Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 279);
            label6.Name = "label6";
            label6.Size = new Size(0, 24);
            label6.TabIndex = 4;
            // 
            // FormAddUpdStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 215, 146);
            ClientSize = new Size(408, 318);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(buttonSave);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(479, 341);
            Margin = new Padding(4);
            MaximumSize = new Size(426, 365);
            MinimumSize = new Size(426, 365);
            Name = "FormAddUpdStaff";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public Label labelINFOStaff;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Button button2;
        private Button buttonSave;
        private Label label6;
        public TextBox textBoxPost;
        public TextBox textBoxPatronymic;
        public TextBox textBoxName;
        public TextBox textBoxSurname;
        public MaskedTextBox maskedTextBoxPhone;
    }
}