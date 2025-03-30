namespace SmartWarehouse_360
{
    partial class FormAddUpdCatProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUpdCatProd));
            textBoxDescCat = new TextBox();
            textBoxNameCat = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            labelINFOKat = new Label();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxDescCat
            // 
            textBoxDescCat.Location = new Point(248, 58);
            textBoxDescCat.Multiline = true;
            textBoxDescCat.Name = "textBoxDescCat";
            textBoxDescCat.Size = new Size(210, 68);
            textBoxDescCat.TabIndex = 18;
            // 
            // textBoxNameCat
            // 
            textBoxNameCat.Location = new Point(248, 30);
            textBoxNameCat.Name = "textBoxNameCat";
            textBoxNameCat.Size = new Size(210, 26);
            textBoxNameCat.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label3.Location = new Point(18, 58);
            label3.Name = "label3";
            label3.Size = new Size(176, 24);
            label3.TabIndex = 16;
            label3.Text = "Описание категории";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label2.Location = new Point(18, 30);
            label2.Name = "label2";
            label2.Size = new Size(173, 24);
            label2.TabIndex = 15;
            label2.Text = "Название категории";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 108);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 22);
            label1.TabIndex = 14;
            // 
            // buttonCancel
            // 
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancel.Location = new Point(260, 186);
            buttonCancel.Margin = new Padding(4, 5, 4, 5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(197, 55);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "         Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(38, 186);
            buttonSave.Margin = new Padding(4, 5, 4, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(195, 55);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "         Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxDescCat);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxNameCat);
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 132);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 175, 100);
            panel2.Controls.Add(labelINFOKat);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(504, 38);
            panel2.TabIndex = 21;
            // 
            // labelINFOKat
            // 
            labelINFOKat.AutoSize = true;
            labelINFOKat.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelINFOKat.Location = new Point(12, 0);
            labelINFOKat.Name = "labelINFOKat";
            labelINFOKat.Size = new Size(0, 29);
            labelINFOKat.TabIndex = 0;
            // 
            // FormAddUpdCatProd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 215, 146);
            ClientSize = new Size(502, 255);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAddUpdCatProd";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonCancel;
        private Button buttonSave;
        private GroupBox groupBox1;
        private Panel panel2;
        public Label labelINFOKat;
        public TextBox textBoxDescCat;
        public TextBox textBoxNameCat;
    }
}