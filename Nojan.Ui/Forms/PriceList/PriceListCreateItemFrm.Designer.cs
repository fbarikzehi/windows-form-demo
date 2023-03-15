namespace Nojan.Ui.Forms.PriceList
{
    partial class PriceListCreateItemFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceListCreateItemFrm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtCode = new TextBox();
            btnInsert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "نام:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 9);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "قیمت:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 8);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 2;
            label3.Text = "کد:";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(267, 23);
            txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(285, 27);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(173, 23);
            txtPrice.TabIndex = 4;
            txtPrice.KeyUp += txtPrice_KeyUp;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(464, 26);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(135, 23);
            txtCode.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Teal;
            btnInsert.ForeColor = Color.Cornsilk;
            btnInsert.Location = new Point(12, 71);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(146, 32);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "ثبت [Enter]";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // PriceListCreateItemFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 115);
            Controls.Add(btnInsert);
            Controls.Add(txtCode);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PriceListCreateItemFrm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "افزودن آیتم لیست قیمت";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtCode;
        private Button btnInsert;
    }
}