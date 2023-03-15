namespace Nojan.Ui.Forms.Customer
{
    partial class CustomerProjectCreateFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerProjectCreateFrm));
            BtnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            lblCustomerFullName = new Label();
            TxtTitle = new TextBox();
            SuspendLayout();
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.Teal;
            BtnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSave.ForeColor = SystemColors.ControlLight;
            BtnSave.Location = new Point(163, 84);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(140, 33);
            BtnSave.TabIndex = 0;
            BtnSave.Text = " ذخیره [Enter]";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "مشتری:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 37);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "عنوان پروژه:";
            // 
            // lblCustomerFullName
            // 
            lblCustomerFullName.AutoSize = true;
            lblCustomerFullName.Location = new Point(65, 6);
            lblCustomerFullName.Name = "lblCustomerFullName";
            lblCustomerFullName.Size = new Size(0, 15);
            lblCustomerFullName.TabIndex = 3;
            lblCustomerFullName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtTitle
            // 
            TxtTitle.Location = new Point(12, 55);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(433, 23);
            TxtTitle.TabIndex = 4;
            // 
            // CustomerProjectCreateFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 129);
            Controls.Add(TxtTitle);
            Controls.Add(lblCustomerFullName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerProjectCreateFrm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "افزودن پروژه به مشتری";
            Shown += CustomerProjectCreateFrm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSave;
        private Label label1;
        private Label label2;
        private Label lblCustomerFullName;
        private TextBox TxtTitle;
    }
}