namespace Nojan.Ui.Forms.Invoice
{
    partial class InvoicesFrm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesFrm));
            InvoiceGridView = new DataGridView();
            ColumnRowCount = new DataGridViewTextBoxColumn();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNumber = new DataGridViewTextBoxColumn();
            ColumnProjectName = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnTotalPrice = new DataGridViewTextBoxColumn();
            UpdateBtn = new Button();
            PrintBtn = new Button();
            DeleteBtn = new Button();
            panel1 = new Panel();
            lblInvoiceTotal = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lblCode = new Label();
            label3 = new Label();
            lblPhone = new Label();
            label455 = new Label();
            lblName = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)InvoiceGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // InvoiceGridView
            // 
            InvoiceGridView.AllowUserToAddRows = false;
            InvoiceGridView.AllowUserToDeleteRows = false;
            InvoiceGridView.AllowUserToResizeRows = false;
            InvoiceGridView.BackgroundColor = SystemColors.ActiveCaption;
            InvoiceGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InvoiceGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnRowCount, ColumnId, ColumnNumber, ColumnProjectName, ColumnDate, ColumnTotalPrice });
            InvoiceGridView.Location = new Point(12, 50);
            InvoiceGridView.Name = "InvoiceGridView";
            InvoiceGridView.RowTemplate.Height = 25;
            InvoiceGridView.Size = new Size(902, 468);
            InvoiceGridView.TabIndex = 0;
            InvoiceGridView.CellFormatting += InvoiceGridView_CellFormatting;
            // 
            // ColumnRowCount
            // 
            dataGridViewCellStyle1.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnRowCount.DefaultCellStyle = dataGridViewCellStyle1;
            ColumnRowCount.HeaderText = "ردیف";
            ColumnRowCount.Name = "ColumnRowCount";
            ColumnRowCount.Width = 60;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "#";
            ColumnId.Name = "ColumnId";
            ColumnId.Visible = false;
            // 
            // ColumnNumber
            // 
            dataGridViewCellStyle2.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnNumber.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnNumber.HeaderText = "شماره فاکتور ";
            ColumnNumber.Name = "ColumnNumber";
            ColumnNumber.Width = 150;
            // 
            // ColumnProjectName
            // 
            dataGridViewCellStyle3.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnProjectName.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnProjectName.HeaderText = "پروژه";
            ColumnProjectName.Name = "ColumnProjectName";
            ColumnProjectName.Width = 255;
            // 
            // ColumnDate
            // 
            dataGridViewCellStyle4.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnDate.DefaultCellStyle = dataGridViewCellStyle4;
            ColumnDate.HeaderText = "تاریخ صدور";
            ColumnDate.Name = "ColumnDate";
            ColumnDate.Width = 155;
            // 
            // ColumnTotalPrice
            // 
            dataGridViewCellStyle5.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnTotalPrice.DefaultCellStyle = dataGridViewCellStyle5;
            ColumnTotalPrice.HeaderText = "مبلغ کل فاکتور (ریال)";
            ColumnTotalPrice.Name = "ColumnTotalPrice";
            ColumnTotalPrice.Width = 238;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Teal;
            UpdateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBtn.ForeColor = SystemColors.ButtonHighlight;
            UpdateBtn.Location = new Point(15, 575);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(113, 29);
            UpdateBtn.TabIndex = 1;
            UpdateBtn.Text = "ویرایش فاکتور";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // PrintBtn
            // 
            PrintBtn.BackColor = Color.DodgerBlue;
            PrintBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PrintBtn.ForeColor = SystemColors.ButtonHighlight;
            PrintBtn.Location = new Point(149, 575);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(113, 29);
            PrintBtn.TabIndex = 2;
            PrintBtn.Text = "پرینت فاکتور";
            PrintBtn.UseVisualStyleBackColor = false;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Maroon;
            DeleteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = SystemColors.ButtonHighlight;
            DeleteBtn.Location = new Point(801, 575);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(113, 29);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "حذف فاکتور";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(lblInvoiceTotal);
            panel1.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(680, 524);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 28);
            panel1.TabIndex = 4;
            // 
            // lblInvoiceTotal
            // 
            lblInvoiceTotal.AutoSize = true;
            lblInvoiceTotal.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInvoiceTotal.Location = new Point(109, 7);
            lblInvoiceTotal.Name = "lblInvoiceTotal";
            lblInvoiceTotal.Size = new Size(14, 20);
            lblInvoiceTotal.TabIndex = 6;
            lblInvoiceTotal.Text = "0";
            lblInvoiceTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(554, 531);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 5;
            label1.Text = "جمع کل فاکتورها(ریال):";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(lblCode);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblPhone);
            panel2.Controls.Add(label455);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(902, 43);
            panel2.TabIndex = 6;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(234, 15);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(0, 15);
            lblCode.TabIndex = 5;
            lblCode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 15);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 4;
            label3.Text = "کد:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(513, 15);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(0, 15);
            lblPhone.TabIndex = 3;
            lblPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label455
            // 
            label455.AutoSize = true;
            label455.Location = new Point(554, 15);
            label455.Name = "label455";
            label455.Size = new Size(35, 15);
            label455.TabIndex = 2;
            label455.Text = "تلفن: ";
            label455.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(729, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 15);
            lblName.TabIndex = 1;
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(817, 15);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 0;
            label2.Text = "مشتری/شرکت: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InvoicesFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 616);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(DeleteBtn);
            Controls.Add(PrintBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(InvoiceGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InvoicesFrm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "لیست فاکتورها";
            Shown += InvoicesFrm_Shown;
            ((System.ComponentModel.ISupportInitialize)InvoiceGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView InvoiceGridView;
        private Button UpdateBtn;
        private Button PrintBtn;
        private Button DeleteBtn;
        private Panel panel1;
        private Label label1;
        private Label lblInvoiceTotal;
        private Panel panel2;
        private Label label2;
        private Label label455;
        private Label lblName;
        private Label label3;
        private Label lblPhone;
        private Label lblCode;
        private DataGridViewTextBoxColumn ColumnRowCount;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNumber;
        private DataGridViewTextBoxColumn ColumnProjectName;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnTotalPrice;
    }
}