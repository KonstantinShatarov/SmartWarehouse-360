namespace SmartWarehouse_360
{
    partial class FormDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesktop));
            menuStrip1 = new MenuStrip();
            документыToolStripMenuItem = new ToolStripMenuItem();
            накладныеToolStripMenuItem = new ToolStripMenuItem();
            поставщикиToolStripMenuItem = new ToolStripMenuItem();
            ассортиментToolStripMenuItem = new ToolStripMenuItem();
            сотрудникиToolStripMenuItem = new ToolStripMenuItem();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            категорииТоваровToolStripMenuItem = new ToolStripMenuItem();
            buttonInvoice = new Button();
            buttonPostav = new Button();
            buttonAssort = new Button();
            buttonStaff = new Button();
            pictureBox1 = new PictureBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(0, 175, 100);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { документыToolStripMenuItem, справочникиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(567, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // документыToolStripMenuItem
            // 
            документыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { накладныеToolStripMenuItem, поставщикиToolStripMenuItem, ассортиментToolStripMenuItem, сотрудникиToolStripMenuItem });
            документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            документыToolStripMenuItem.Size = new Size(101, 24);
            документыToolStripMenuItem.Text = "Документы";
            // 
            // накладныеToolStripMenuItem
            // 
            накладныеToolStripMenuItem.Image = (Image)resources.GetObject("накладныеToolStripMenuItem.Image");
            накладныеToolStripMenuItem.Name = "накладныеToolStripMenuItem";
            накладныеToolStripMenuItem.Size = new Size(183, 26);
            накладныеToolStripMenuItem.Text = "Накладные";
            накладныеToolStripMenuItem.Click += накладныеToolStripMenuItem_Click;
            // 
            // поставщикиToolStripMenuItem
            // 
            поставщикиToolStripMenuItem.Image = (Image)resources.GetObject("поставщикиToolStripMenuItem.Image");
            поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            поставщикиToolStripMenuItem.Size = new Size(183, 26);
            поставщикиToolStripMenuItem.Text = "Поставщики";
            поставщикиToolStripMenuItem.Click += поставщикиToolStripMenuItem_Click;
            // 
            // ассортиментToolStripMenuItem
            // 
            ассортиментToolStripMenuItem.Image = (Image)resources.GetObject("ассортиментToolStripMenuItem.Image");
            ассортиментToolStripMenuItem.Name = "ассортиментToolStripMenuItem";
            ассортиментToolStripMenuItem.Size = new Size(183, 26);
            ассортиментToolStripMenuItem.Text = "Ассортимент";
            ассортиментToolStripMenuItem.Click += ассортиментToolStripMenuItem_Click;
            // 
            // сотрудникиToolStripMenuItem
            // 
            сотрудникиToolStripMenuItem.Image = (Image)resources.GetObject("сотрудникиToolStripMenuItem.Image");
            сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            сотрудникиToolStripMenuItem.Size = new Size(183, 26);
            сотрудникиToolStripMenuItem.Text = "Сотрудники";
            сотрудникиToolStripMenuItem.Click += сотрудникиToolStripMenuItem_Click;
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { категорииТоваровToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(117, 24);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // категорииТоваровToolStripMenuItem
            // 
            категорииТоваровToolStripMenuItem.Image = (Image)resources.GetObject("категорииТоваровToolStripMenuItem.Image");
            категорииТоваровToolStripMenuItem.Name = "категорииТоваровToolStripMenuItem";
            категорииТоваровToolStripMenuItem.Size = new Size(226, 26);
            категорииТоваровToolStripMenuItem.Text = "Категории товаров";
            категорииТоваровToolStripMenuItem.Click += категорииТоваровToolStripMenuItem_Click;
            // 
            // buttonInvoice
            // 
            buttonInvoice.Image = (Image)resources.GetObject("buttonInvoice.Image");
            buttonInvoice.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInvoice.Location = new Point(14, 53);
            buttonInvoice.Margin = new Padding(3, 4, 3, 4);
            buttonInvoice.Name = "buttonInvoice";
            buttonInvoice.Size = new Size(190, 69);
            buttonInvoice.TabIndex = 2;
            buttonInvoice.Text = "          Накладные";
            buttonInvoice.UseVisualStyleBackColor = true;
            buttonInvoice.Click += buttonInvoice_Click;
            // 
            // buttonPostav
            // 
            buttonPostav.Image = (Image)resources.GetObject("buttonPostav.Image");
            buttonPostav.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPostav.Location = new Point(14, 131);
            buttonPostav.Margin = new Padding(3, 4, 3, 4);
            buttonPostav.Name = "buttonPostav";
            buttonPostav.Size = new Size(190, 69);
            buttonPostav.TabIndex = 3;
            buttonPostav.Text = "          Поставщики";
            buttonPostav.UseVisualStyleBackColor = true;
            buttonPostav.Click += buttonPostav_Click;
            // 
            // buttonAssort
            // 
            buttonAssort.Image = (Image)resources.GetObject("buttonAssort.Image");
            buttonAssort.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAssort.Location = new Point(14, 208);
            buttonAssort.Margin = new Padding(3, 4, 3, 4);
            buttonAssort.Name = "buttonAssort";
            buttonAssort.Size = new Size(190, 77);
            buttonAssort.TabIndex = 4;
            buttonAssort.Text = "          Ассортимент";
            buttonAssort.UseVisualStyleBackColor = true;
            buttonAssort.Click += buttonAssort_Click;
            // 
            // buttonStaff
            // 
            buttonStaff.Image = (Image)resources.GetObject("buttonStaff.Image");
            buttonStaff.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStaff.Location = new Point(14, 293);
            buttonStaff.Margin = new Padding(3, 4, 3, 4);
            buttonStaff.Name = "buttonStaff";
            buttonStaff.Size = new Size(190, 69);
            buttonStaff.TabIndex = 5;
            buttonStaff.Text = "          Сотрудники";
            buttonStaff.UseVisualStyleBackColor = true;
            buttonStaff.Click += buttonStaff_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(224, 34);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 354);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(0, 175, 100);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 389);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(567, 26);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(193, 20);
            toolStripStatusLabel1.Text = "Должность: Админ. склада";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Margin = new Padding(280, 4, 0, 2);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(77, 20);
            toolStripStatusLabel2.Text = "дд.мм.гггг";
            toolStripStatusLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormDesktop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 215, 146);
            ClientSize = new Size(567, 415);
            Controls.Add(statusStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonStaff);
            Controls.Add(buttonAssort);
            Controls.Add(buttonPostav);
            Controls.Add(buttonInvoice);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(514, 358);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(585, 462);
            MinimumSize = new Size(585, 462);
            Name = "FormDesktop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmartWarehouse 360";
            FormClosing += FormDesktop_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem документыToolStripMenuItem;
        private ToolStripMenuItem накладныеToolStripMenuItem;
        private ToolStripMenuItem поставщикиToolStripMenuItem;
        private ToolStripMenuItem ассортиментToolStripMenuItem;
        private ToolStripMenuItem сотрудникиToolStripMenuItem;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem категорииТоваровToolStripMenuItem;
        private Button buttonInvoice;
        private Button buttonPostav;
        private Button buttonAssort;
        private Button buttonStaff;
        private PictureBox pictureBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}