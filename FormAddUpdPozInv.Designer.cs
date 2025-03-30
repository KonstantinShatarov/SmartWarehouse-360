namespace SmartWarehouse_360
{
    partial class FormAddUpdPozInv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUpdPozInv));
            panel1 = new Panel();
            labelINFOPoz = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            buttonAddPoz = new Button();
            textBoxItogSumm = new TextBox();
            textBoxKolProd = new TextBox();
            textBoxPriseEd = new TextBox();
            textBoxArticle = new TextBox();
            groupBox1 = new GroupBox();
            textBoxCategorii = new TextBox();
            textBoxEdIzm = new TextBox();
            comboBoxNameProd = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 175, 100);
            panel1.Controls.Add(labelINFOPoz);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(4, 8, 4, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 74);
            panel1.TabIndex = 2;
            // 
            // labelINFOPoz
            // 
            labelINFOPoz.AutoSize = true;
            labelINFOPoz.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelINFOPoz.Location = new Point(25, 25);
            labelINFOPoz.Name = "labelINFOPoz";
            labelINFOPoz.Size = new Size(0, 29);
            labelINFOPoz.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancel.Location = new Point(447, 369);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(187, 57);
            buttonCancel.TabIndex = 24;
            buttonCancel.Text = "         Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += button2_Click;
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(254, 369);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(187, 57);
            buttonSave.TabIndex = 23;
            buttonSave.Text = "         Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonAddPoz
            // 
            buttonAddPoz.Image = (Image)resources.GetObject("buttonAddPoz.Image");
            buttonAddPoz.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddPoz.Location = new Point(61, 369);
            buttonAddPoz.Margin = new Padding(3, 4, 3, 4);
            buttonAddPoz.Name = "buttonAddPoz";
            buttonAddPoz.Size = new Size(187, 57);
            buttonAddPoz.TabIndex = 25;
            buttonAddPoz.Text = "         Добавить";
            buttonAddPoz.UseVisualStyleBackColor = true;
            buttonAddPoz.Click += buttonAddPoz_Click;
            // 
            // textBoxItogSumm
            // 
            textBoxItogSumm.Enabled = false;
            textBoxItogSumm.Location = new Point(281, 201);
            textBoxItogSumm.Name = "textBoxItogSumm";
            textBoxItogSumm.Size = new Size(300, 27);
            textBoxItogSumm.TabIndex = 28;
            // 
            // textBoxKolProd
            // 
            textBoxKolProd.Location = new Point(281, 168);
            textBoxKolProd.Name = "textBoxKolProd";
            textBoxKolProd.Size = new Size(300, 27);
            textBoxKolProd.TabIndex = 29;
            textBoxKolProd.TextChanged += textBoxKolProd_TextChanged;
            textBoxKolProd.KeyPress += textBoxKolProd_KeyPress;
            // 
            // textBoxPriseEd
            // 
            textBoxPriseEd.Location = new Point(281, 135);
            textBoxPriseEd.Name = "textBoxPriseEd";
            textBoxPriseEd.Size = new Size(300, 27);
            textBoxPriseEd.TabIndex = 30;
            textBoxPriseEd.KeyPress += textBoxPriseEd_KeyPress;
            // 
            // textBoxArticle
            // 
            textBoxArticle.Enabled = false;
            textBoxArticle.Location = new Point(281, 69);
            textBoxArticle.MaxLength = 12;
            textBoxArticle.Name = "textBoxArticle";
            textBoxArticle.Size = new Size(300, 27);
            textBoxArticle.TabIndex = 32;
            textBoxArticle.KeyPress += textBoxArticle_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxCategorii);
            groupBox1.Controls.Add(textBoxEdIzm);
            groupBox1.Controls.Add(comboBoxNameProd);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxArticle);
            groupBox1.Controls.Add(textBoxItogSumm);
            groupBox1.Controls.Add(textBoxPriseEd);
            groupBox1.Controls.Add(textBoxKolProd);
            groupBox1.Location = new Point(26, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(638, 277);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            // 
            // textBoxCategorii
            // 
            textBoxCategorii.Enabled = false;
            textBoxCategorii.Location = new Point(281, 233);
            textBoxCategorii.Name = "textBoxCategorii";
            textBoxCategorii.Size = new Size(300, 27);
            textBoxCategorii.TabIndex = 44;
            // 
            // textBoxEdIzm
            // 
            textBoxEdIzm.Enabled = false;
            textBoxEdIzm.Location = new Point(281, 102);
            textBoxEdIzm.MaxLength = 12;
            textBoxEdIzm.Name = "textBoxEdIzm";
            textBoxEdIzm.Size = new Size(300, 27);
            textBoxEdIzm.TabIndex = 43;
            // 
            // comboBoxNameProd
            // 
            comboBoxNameProd.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNameProd.FormattingEnabled = true;
            comboBoxNameProd.Location = new Point(281, 36);
            comboBoxNameProd.Name = "comboBoxNameProd";
            comboBoxNameProd.Size = new Size(300, 30);
            comboBoxNameProd.TabIndex = 42;
            comboBoxNameProd.TextChanged += comboBoxNameProd_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 233);
            label7.Name = "label7";
            label7.Size = new Size(137, 22);
            label7.TabIndex = 39;
            label7.Text = "Категория товара";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 201);
            label6.Name = "label6";
            label6.Size = new Size(202, 22);
            label6.TabIndex = 38;
            label6.Text = "Общая стоимость позиции";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 168);
            label5.Name = "label5";
            label5.Size = new Size(149, 22);
            label5.TabIndex = 37;
            label5.Text = "Количество товара";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 135);
            label4.Name = "label4";
            label4.Size = new Size(142, 22);
            label4.TabIndex = 36;
            label4.Text = "Цена за ед. товара";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 102);
            label3.Name = "label3";
            label3.Size = new Size(112, 22);
            label3.TabIndex = 35;
            label3.Text = "Ед. измерения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 69);
            label2.Name = "label2";
            label2.Size = new Size(69, 22);
            label2.TabIndex = 34;
            label2.Text = "Артикул";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 36);
            label1.Name = "label1";
            label1.Size = new Size(131, 22);
            label1.TabIndex = 33;
            label1.Text = "Название товара";
            // 
            // FormAddUpdPozInv
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 215, 146);
            ClientSize = new Size(673, 437);
            Controls.Add(groupBox1);
            Controls.Add(buttonAddPoz);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(691, 484);
            MinimumSize = new Size(691, 484);
            Name = "FormAddUpdPozInv";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Label labelINFOPoz;
        private Button buttonCancel;
        private Button buttonSave;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public Button buttonAddPoz;
        public TextBox textBoxItogSumm;
        public TextBox textBoxKolProd;
        public TextBox textBoxPriseEd;
        public TextBox textBoxArticle;
        public ComboBox comboBoxNameProd;
        public TextBox textBoxCategorii;
        public TextBox textBoxEdIzm;
    }
}