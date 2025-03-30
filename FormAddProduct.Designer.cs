namespace SmartWarehouse_360
{
    partial class FormAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProduct));
            comboBoxEdIzm = new ComboBox();
            comboBoxCategorii = new ComboBox();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxArticle = new TextBox();
            textBoxDesc = new TextBox();
            textBoxOpisanie = new TextBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            labelINFOPoz = new Label();
            groupBox1 = new GroupBox();
            textBoxNameProd = new TextBox();
            panel1 = new Panel();
            buttonAddProd = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxEdIzm
            // 
            comboBoxEdIzm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEdIzm.FormattingEnabled = true;
            comboBoxEdIzm.Items.AddRange(new object[] { "Упаковка", "Комплект", "Пачка", "Штука", "Погонный метр", "Квадратный метр", "Кубический метр", "Литр", "Килограмм", "Тонна" });
            comboBoxEdIzm.Location = new Point(316, 109);
            comboBoxEdIzm.Margin = new Padding(3, 4, 3, 4);
            comboBoxEdIzm.Name = "comboBoxEdIzm";
            comboBoxEdIzm.Size = new Size(337, 30);
            comboBoxEdIzm.TabIndex = 41;
            // 
            // comboBoxCategorii
            // 
            comboBoxCategorii.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategorii.FormattingEnabled = true;
            comboBoxCategorii.Location = new Point(316, 147);
            comboBoxCategorii.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategorii.Name = "comboBoxCategorii";
            comboBoxCategorii.Size = new Size(337, 30);
            comboBoxCategorii.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 151);
            label7.Name = "label7";
            label7.Size = new Size(137, 22);
            label7.TabIndex = 39;
            label7.Text = "Категория товара";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(72, 282);
            label9.Name = "label9";
            label9.Size = new Size(133, 44);
            label9.TabIndex = 38;
            label9.Text = "Дополнительная \r\nинформация";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(72, 188);
            label8.Name = "label8";
            label8.Size = new Size(79, 22);
            label8.TabIndex = 37;
            label8.Text = "Описание";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 112);
            label3.Name = "label3";
            label3.Size = new Size(112, 22);
            label3.TabIndex = 35;
            label3.Text = "Ед. измерения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 76);
            label2.Name = "label2";
            label2.Size = new Size(69, 22);
            label2.TabIndex = 34;
            label2.Text = "Артикул";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 40);
            label1.Name = "label1";
            label1.Size = new Size(131, 22);
            label1.TabIndex = 33;
            label1.Text = "Название товара";
            // 
            // textBoxArticle
            // 
            textBoxArticle.Location = new Point(316, 76);
            textBoxArticle.MaxLength = 12;
            textBoxArticle.Name = "textBoxArticle";
            textBoxArticle.Size = new Size(337, 27);
            textBoxArticle.TabIndex = 32;
            textBoxArticle.KeyPress += textBoxArticle_KeyPress;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(316, 278);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(337, 95);
            textBoxDesc.TabIndex = 28;
            // 
            // textBoxOpisanie
            // 
            textBoxOpisanie.Location = new Point(316, 188);
            textBoxOpisanie.Multiline = true;
            textBoxOpisanie.Name = "textBoxOpisanie";
            textBoxOpisanie.Size = new Size(337, 83);
            textBoxOpisanie.TabIndex = 29;
            // 
            // buttonCancel
            // 
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancel.Location = new Point(512, 491);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(210, 63);
            buttonCancel.TabIndex = 36;
            buttonCancel.Text = "         Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(295, 491);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(210, 63);
            buttonSave.TabIndex = 35;
            buttonSave.Text = "         Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelINFOPoz
            // 
            labelINFOPoz.AutoSize = true;
            labelINFOPoz.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelINFOPoz.Location = new Point(28, 28);
            labelINFOPoz.Name = "labelINFOPoz";
            labelINFOPoz.Size = new Size(0, 29);
            labelINFOPoz.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxNameProd);
            groupBox1.Controls.Add(comboBoxEdIzm);
            groupBox1.Controls.Add(comboBoxCategorii);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxArticle);
            groupBox1.Controls.Add(textBoxDesc);
            groupBox1.Controls.Add(textBoxOpisanie);
            groupBox1.Location = new Point(37, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(718, 390);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            // 
            // textBoxNameProd
            // 
            textBoxNameProd.Location = new Point(316, 40);
            textBoxNameProd.MaxLength = 255;
            textBoxNameProd.Name = "textBoxNameProd";
            textBoxNameProd.Size = new Size(337, 27);
            textBoxNameProd.TabIndex = 42;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 175, 100);
            panel1.Controls.Add(labelINFOPoz);
            panel1.Location = new Point(-3, -1);
            panel1.Margin = new Padding(4, 9, 4, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 81);
            panel1.TabIndex = 34;
            // 
            // buttonAddProd
            // 
            buttonAddProd.Image = (Image)resources.GetObject("buttonAddProd.Image");
            buttonAddProd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddProd.Location = new Point(78, 491);
            buttonAddProd.Margin = new Padding(3, 4, 3, 4);
            buttonAddProd.Name = "buttonAddProd";
            buttonAddProd.Size = new Size(210, 63);
            buttonAddProd.TabIndex = 37;
            buttonAddProd.Text = "         Добавить";
            buttonAddProd.UseVisualStyleBackColor = true;
            buttonAddProd.Click += buttonAddProd_Click;
            // 
            // FormAddProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 215, 146);
            ClientSize = new Size(790, 569);
            Controls.Add(buttonAddProd);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(808, 616);
            MinimumSize = new Size(808, 616);
            Name = "FormAddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public ComboBox comboBoxEdIzm;
        public ComboBox comboBoxCategorii;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox textBoxArticle;
        public TextBox textBoxDesc;
        public TextBox textBoxOpisanie;
        private Button buttonCancel;
        private Button buttonSave;
        public Label labelINFOPoz;
        private GroupBox groupBox1;
        private Panel panel1;
        public Button buttonAddProd;
        public TextBox textBoxNameProd;
    }
}