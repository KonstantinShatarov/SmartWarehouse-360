namespace SmartWarehouse_360
{
    partial class FormAddUpdInvoise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUpdInvoise));
            panel1 = new Panel();
            labelINFOPost = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            groupBox1 = new GroupBox();
            maskedTextBoxDateInv = new MaskedTextBox();
            comboBoxPostav = new ComboBox();
            textBoxDesc = new TextBox();
            textBoxNumInv = new TextBox();
            textBoxObshSumm = new TextBox();
            comboBoxStaff = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 175, 100);
            panel1.Controls.Add(labelINFOPost);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(4, 7, 4, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 67);
            panel1.TabIndex = 1;
            // 
            // labelINFOPost
            // 
            labelINFOPost.AutoSize = true;
            labelINFOPost.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelINFOPost.Location = new Point(22, 23);
            labelINFOPost.Name = "labelINFOPost";
            labelINFOPost.Size = new Size(0, 29);
            labelINFOPost.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancel.Location = new Point(349, 432);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(176, 67);
            buttonCancel.TabIndex = 17;
            buttonCancel.Text = "         Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(149, 432);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(176, 67);
            buttonSave.TabIndex = 16;
            buttonSave.Text = "         Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBoxDateInv);
            groupBox1.Controls.Add(comboBoxPostav);
            groupBox1.Controls.Add(textBoxDesc);
            groupBox1.Controls.Add(textBoxNumInv);
            groupBox1.Controls.Add(textBoxObshSumm);
            groupBox1.Controls.Add(comboBoxStaff);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(22, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(615, 347);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // maskedTextBoxDateInv
            // 
            maskedTextBoxDateInv.Location = new Point(327, 119);
            maskedTextBoxDateInv.Mask = "00/00/0000";
            maskedTextBoxDateInv.Name = "maskedTextBoxDateInv";
            maskedTextBoxDateInv.Size = new Size(254, 27);
            maskedTextBoxDateInv.TabIndex = 25;
            maskedTextBoxDateInv.ValidatingType = typeof(DateTime);
            // 
            // comboBoxPostav
            // 
            comboBoxPostav.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPostav.FormattingEnabled = true;
            comboBoxPostav.Location = new Point(327, 80);
            comboBoxPostav.Margin = new Padding(3, 4, 3, 4);
            comboBoxPostav.Name = "comboBoxPostav";
            comboBoxPostav.Size = new Size(254, 30);
            comboBoxPostav.TabIndex = 24;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(327, 226);
            textBoxDesc.Margin = new Padding(3, 4, 3, 4);
            textBoxDesc.MaxLength = 255;
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(254, 86);
            textBoxDesc.TabIndex = 23;
            // 
            // textBoxNumInv
            // 
            textBoxNumInv.Location = new Point(327, 45);
            textBoxNumInv.Margin = new Padding(3, 4, 3, 4);
            textBoxNumInv.MaxLength = 10;
            textBoxNumInv.Name = "textBoxNumInv";
            textBoxNumInv.Size = new Size(254, 27);
            textBoxNumInv.TabIndex = 22;
            textBoxNumInv.KeyPress += textBoxNumInv_KeyPress;
            // 
            // textBoxObshSumm
            // 
            textBoxObshSumm.Location = new Point(327, 153);
            textBoxObshSumm.Margin = new Padding(3, 4, 3, 4);
            textBoxObshSumm.MaxLength = 10;
            textBoxObshSumm.Name = "textBoxObshSumm";
            textBoxObshSumm.Size = new Size(254, 27);
            textBoxObshSumm.TabIndex = 20;
            textBoxObshSumm.KeyPress += textBoxObshSumm_KeyPress;
            // 
            // comboBoxStaff
            // 
            comboBoxStaff.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStaff.FormattingEnabled = true;
            comboBoxStaff.Location = new Point(327, 188);
            comboBoxStaff.Margin = new Padding(3, 4, 3, 4);
            comboBoxStaff.Name = "comboBoxStaff";
            comboBoxStaff.Size = new Size(254, 30);
            comboBoxStaff.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 188);
            label6.Name = "label6";
            label6.Size = new Size(220, 22);
            label6.TabIndex = 17;
            label6.Text = "Принял/проверил сотрудник*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 226);
            label5.Name = "label5";
            label5.Size = new Size(136, 22);
            label5.TabIndex = 16;
            label5.Text = "Доп. информация";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 153);
            label3.Name = "label3";
            label3.Size = new Size(190, 22);
            label3.TabIndex = 14;
            label3.Text = "Общая сумма накладной*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 83);
            label4.Name = "label4";
            label4.Size = new Size(94, 22);
            label4.TabIndex = 12;
            label4.Text = "Поставщик*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 118);
            label2.Name = "label2";
            label2.Size = new Size(127, 22);
            label2.TabIndex = 13;
            label2.Text = "Дата накладной*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 48);
            label1.Name = "label1";
            label1.Size = new Size(140, 22);
            label1.TabIndex = 12;
            label1.Text = "Номер накладной*";
            // 
            // FormAddUpdInvoise
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 215, 146);
            ClientSize = new Size(655, 514);
            Controls.Add(groupBox1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(673, 561);
            MinimumSize = new Size(673, 561);
            Name = "FormAddUpdInvoise";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Label labelINFOPost;
        private Button buttonCancel;
        private Button buttonSave;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        public MaskedTextBox maskedTextBoxDateInv;
        public TextBox textBoxDesc;
        public TextBox textBoxNumInv;
        public TextBox textBoxObshSumm;
        public ComboBox comboBoxStaff;
        public ComboBox comboBoxPostav;
    }
}