namespace Nojan.Ui.Forms.Invoice
{
    partial class InvoiceSettingFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceSettingFrm));
            label1 = new Label();
            txtJobTitle = new TextBox();
            label2 = new Label();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            label3 = new Label();
            UpdateBtn = new Button();
            CancelBtn = new Button();
            label4 = new Label();
            txtInitNumber = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "عنوان سربرگ:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(20, 35);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(211, 23);
            txtJobTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 17);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "تلفن:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(269, 35);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(172, 23);
            txtPhone.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(20, 91);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(768, 23);
            txtAddress.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 73);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "آدرس:";
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Teal;
            UpdateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBtn.ForeColor = SystemColors.ButtonHighlight;
            UpdateBtn.Location = new Point(19, 139);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(116, 35);
            UpdateBtn.TabIndex = 6;
            UpdateBtn.Text = "ثبت تغییرات";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.Maroon;
            CancelBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CancelBtn.ForeColor = SystemColors.ButtonHighlight;
            CancelBtn.Location = new Point(675, 139);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(116, 35);
            CancelBtn.TabIndex = 7;
            CancelBtn.Text = "انصراف";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(486, 17);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 8;
            label4.Text = "شروع شماره فاکتور:";
            // 
            // txtInitNumber
            // 
            txtInitNumber.Location = new Point(486, 35);
            txtInitNumber.Name = "txtInitNumber";
            txtInitNumber.Size = new Size(102, 23);
            txtInitNumber.TabIndex = 9;
            // 
            // InvoiceSettingFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 196);
            Controls.Add(txtInitNumber);
            Controls.Add(label4);
            Controls.Add(CancelBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtJobTitle);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InvoiceSettingFrm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "تنظیمات فاکتور";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtJobTitle;
        private Label label2;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Label label3;
        private Button UpdateBtn;
        private Button CancelBtn;
        private Label label4;
        private TextBox txtInitNumber;
    }
}