namespace Nojan.Ui.Forms.Invoice
{
    partial class InvoiceSelectItemsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceSelectItemsFrm));
            treeViewPriceLists = new TreeView();
            button1 = new Button();
            SuspendLayout();
            // 
            // treeViewPriceLists
            // 
            treeViewPriceLists.CheckBoxes = true;
            treeViewPriceLists.Location = new Point(1, 0);
            treeViewPriceLists.Name = "treeViewPriceLists";
            treeViewPriceLists.RightToLeftLayout = true;
            treeViewPriceLists.ShowPlusMinus = false;
            treeViewPriceLists.Size = new Size(743, 604);
            treeViewPriceLists.TabIndex = 0;
            treeViewPriceLists.AfterCheck += treeViewPriceLists_AfterCheck;
            treeViewPriceLists.DrawNode += treeViewPriceLists_DrawNode;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Location = new Point(12, 610);
            button1.Name = "button1";
            button1.Size = new Size(159, 36);
            button1.TabIndex = 1;
            button1.Text = "ویرایش یا ثبت لیست قیمت";
            button1.UseVisualStyleBackColor = false;
            // 
            // InvoiceSelectItemsFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 652);
            Controls.Add(button1);
            Controls.Add(treeViewPriceLists);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InvoiceSelectItemsFrm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = " انتخاب خدمات و کالا";
            Load += InvoiceSelectItemsFrm_Load;
            Shown += InvoiceSelectItemsFrm_Shown;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeViewPriceLists;
        private Button button1;
    }
}