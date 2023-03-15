namespace Nojan.Ui.Forms.Customer
{
    partial class CustomerCreateFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerCreateFrm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            customerNameTxt = new TextBox();
            customerPhoneTxt = new TextBox();
            customerMobileTxt = new TextBox();
            customerAddressTxt = new TextBox();
            createBtn = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(170, 15);
            label1.TabIndex = 0;
            label1.Text = "نام و نام خانوادگی / عنوان شرکت:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 67);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "تلفن:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 120);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "تلفن همراه:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 203);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "آدرس:";
            // 
            // customerNameTxt
            // 
            customerNameTxt.Location = new Point(28, 39);
            customerNameTxt.Name = "customerNameTxt";
            customerNameTxt.Size = new Size(303, 23);
            customerNameTxt.TabIndex = 4;
            // 
            // customerPhoneTxt
            // 
            customerPhoneTxt.Location = new Point(28, 85);
            customerPhoneTxt.Name = "customerPhoneTxt";
            customerPhoneTxt.Size = new Size(303, 23);
            customerPhoneTxt.TabIndex = 5;
            // 
            // customerMobileTxt
            // 
            customerMobileTxt.Location = new Point(28, 138);
            customerMobileTxt.Name = "customerMobileTxt";
            customerMobileTxt.Size = new Size(303, 23);
            customerMobileTxt.TabIndex = 6;
            // 
            // customerAddressTxt
            // 
            customerAddressTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customerAddressTxt.Location = new Point(28, 221);
            customerAddressTxt.Multiline = true;
            customerAddressTxt.Name = "customerAddressTxt";
            customerAddressTxt.Size = new Size(303, 341);
            customerAddressTxt.TabIndex = 7;
            // 
            // createBtn
            // 
            createBtn.BackColor = Color.Teal;
            createBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createBtn.ForeColor = SystemColors.ButtonHighlight;
            createBtn.Location = new Point(28, 568);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(104, 36);
            createBtn.TabIndex = 8;
            createBtn.Text = "ثبت تغییرات";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(17, 23);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 9;
            label5.Text = "*";
            // 
            // CustomerCreateFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 616);
            Controls.Add(label5);
            Controls.Add(createBtn);
            Controls.Add(customerAddressTxt);
            Controls.Add(customerMobileTxt);
            Controls.Add(customerPhoneTxt);
            Controls.Add(customerNameTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerCreateFrm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ثبت اطلاعات مشتری جدید";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox customerNameTxt;
        private TextBox customerPhoneTxt;
        private TextBox customerMobileTxt;
        private TextBox customerAddressTxt;
        private Button createBtn;
        private Label label5;
    }
}