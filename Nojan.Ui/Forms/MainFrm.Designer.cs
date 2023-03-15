namespace Nojan.Ui.Forms
{
    partial class MainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            مشتریانToolStripMenuItem = new ToolStripMenuItem();
            CustomerMenuItem = new ToolStripMenuItem();
            CreateCustomerMenuItem = new ToolStripMenuItem();
            خدماتوکالاToolStripMenuItem = new ToolStripMenuItem();
            PriceListMenuItem = new ToolStripMenuItem();
            تنظیماتToolStripMenuItem = new ToolStripMenuItem();
            InvoiceSettingMenuItem = new ToolStripMenuItem();
            CreatePriceListMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Yekan", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(11, 651);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 18);
            label1.TabIndex = 1;
            label1.Text = "گروه نرم افزاری نیترو";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Yekan", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(922, 651);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 18);
            label2.TabIndex = 2;
            label2.Text = "نسخه 0.1 (آزمایشی)";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuHighlight;
            menuStrip1.Font = new Font("B Traffic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { مشتریانToolStripMenuItem, خدماتوکالاToolStripMenuItem, تنظیماتToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 4, 0, 4);
            menuStrip1.Size = new Size(1052, 36);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // مشتریانToolStripMenuItem
            // 
            مشتریانToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CustomerMenuItem, CreateCustomerMenuItem });
            مشتریانToolStripMenuItem.Name = "مشتریانToolStripMenuItem";
            مشتریانToolStripMenuItem.Size = new Size(66, 28);
            مشتریانToolStripMenuItem.Text = "مشتریان";
            // 
            // CustomerMenuItem
            // 
            CustomerMenuItem.Name = "CustomerMenuItem";
            CustomerMenuItem.Size = new Size(175, 28);
            CustomerMenuItem.Text = "لیست مشتریان";
            CustomerMenuItem.Click += CustomerMenuItem_Click;
            // 
            // CreateCustomerMenuItem
            // 
            CreateCustomerMenuItem.Name = "CreateCustomerMenuItem";
            CreateCustomerMenuItem.Size = new Size(175, 28);
            CreateCustomerMenuItem.Text = "ثبت مشتری جدید";
            CreateCustomerMenuItem.Click += CreateCustomerMenuItem_Click;
            // 
            // خدماتوکالاToolStripMenuItem
            // 
            خدماتوکالاToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PriceListMenuItem, CreatePriceListMenuItem });
            خدماتوکالاToolStripMenuItem.Name = "خدماتوکالاToolStripMenuItem";
            خدماتوکالاToolStripMenuItem.Size = new Size(88, 28);
            خدماتوکالاToolStripMenuItem.Text = "لیست قیمت";
            // 
            // PriceListMenuItem
            // 
            PriceListMenuItem.Name = "PriceListMenuItem";
            PriceListMenuItem.Size = new Size(203, 28);
            PriceListMenuItem.Text = "لیست قیمت ها";
            PriceListMenuItem.Click += PriceListMenuItem_Click;
            // 
            // تنظیماتToolStripMenuItem
            // 
            تنظیماتToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { InvoiceSettingMenuItem });
            تنظیماتToolStripMenuItem.Name = "تنظیماتToolStripMenuItem";
            تنظیماتToolStripMenuItem.Size = new Size(66, 28);
            تنظیماتToolStripMenuItem.Text = "تنظیمات";
            // 
            // InvoiceSettingMenuItem
            // 
            InvoiceSettingMenuItem.Name = "InvoiceSettingMenuItem";
            InvoiceSettingMenuItem.Size = new Size(159, 28);
            InvoiceSettingMenuItem.Text = "تنظیمات فاکتور";
            InvoiceSettingMenuItem.Click += InvoiceSettingMenuItem_Click;
            // 
            // CreatePriceListMenuItem
            // 
            CreatePriceListMenuItem.Name = "CreatePriceListMenuItem";
            CreatePriceListMenuItem.Size = new Size(203, 28);
            CreatePriceListMenuItem.Text = "ثبت لیست قیمت جدید";
            CreatePriceListMenuItem.Click += CreatePriceListMenuItem_Click;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1052, 678);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("B Zar", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 5, 2, 5);
            MaximizeBox = false;
            Name = "MainFrm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "آریا نوژن";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem مشتریانToolStripMenuItem;
        private ToolStripMenuItem CustomerMenuItem;
        private ToolStripMenuItem خدماتوکالاToolStripMenuItem;
        private ToolStripMenuItem PriceListMenuItem;
        private ToolStripMenuItem تنظیماتToolStripMenuItem;
        private ToolStripMenuItem InvoiceSettingMenuItem;
        private ToolStripMenuItem CreateCustomerMenuItem;
        private ToolStripMenuItem CreatePriceListMenuItem;
    }
}