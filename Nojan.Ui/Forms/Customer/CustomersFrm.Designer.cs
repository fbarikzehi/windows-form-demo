namespace Nojan.Ui.Forms.Customer
{
    partial class CustomersFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersFrm));
            createCustomerBtn = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            cutomersGridView = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnCode = new DataGridViewTextBoxColumn();
            ColumnFullName = new DataGridViewTextBoxColumn();
            ColumnMobile = new DataGridViewTextBoxColumn();
            DeleteRowBtn = new Button();
            CreateInvoiceBtn = new Button();
            ShowCustomerInvoiceListBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)cutomersGridView).BeginInit();
            SuspendLayout();
            // 
            // createCustomerBtn
            // 
            createCustomerBtn.BackColor = Color.FromArgb(0, 192, 192);
            createCustomerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createCustomerBtn.Location = new Point(12, 12);
            createCustomerBtn.Name = "createCustomerBtn";
            createCustomerBtn.Size = new Size(119, 35);
            createCustomerBtn.TabIndex = 0;
            createCustomerBtn.Text = "ثبت مشتری جدید";
            createCustomerBtn.UseVisualStyleBackColor = false;
            createCustomerBtn.Click += createCustomerBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(532, 77);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "نام یا کد مشتری را وارد کنید";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(485, 80);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "جستجو:";
            // 
            // cutomersGridView
            // 
            cutomersGridView.AllowUserToAddRows = false;
            cutomersGridView.AllowUserToDeleteRows = false;
            cutomersGridView.AllowUserToResizeRows = false;
            cutomersGridView.BackgroundColor = SystemColors.ActiveCaption;
            cutomersGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            cutomersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cutomersGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber, ColumnId, ColumnCode, ColumnFullName, ColumnMobile });
            cutomersGridView.Location = new Point(13, 106);
            cutomersGridView.MultiSelect = false;
            cutomersGridView.Name = "cutomersGridView";
            cutomersGridView.ReadOnly = true;
            cutomersGridView.RowTemplate.Height = 25;
            cutomersGridView.Size = new Size(720, 459);
            cutomersGridView.TabIndex = 4;
            cutomersGridView.CellFormatting += cutomersGridView_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            dataGridViewCellStyle1.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnRowNumber.DefaultCellStyle = dataGridViewCellStyle1;
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "#";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Visible = false;
            // 
            // ColumnCode
            // 
            dataGridViewCellStyle2.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnCode.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnCode.HeaderText = "کد مشتری";
            ColumnCode.Name = "ColumnCode";
            ColumnCode.ReadOnly = true;
            ColumnCode.Width = 105;
            // 
            // ColumnFullName
            // 
            dataGridViewCellStyle3.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnFullName.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnFullName.HeaderText = "نام و نام خانوادگی/عنوان شرکت";
            ColumnFullName.Name = "ColumnFullName";
            ColumnFullName.ReadOnly = true;
            ColumnFullName.Width = 270;
            // 
            // ColumnMobile
            // 
            dataGridViewCellStyle4.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnMobile.DefaultCellStyle = dataGridViewCellStyle4;
            ColumnMobile.HeaderText = "تلفن همراه";
            ColumnMobile.Name = "ColumnMobile";
            ColumnMobile.ReadOnly = true;
            ColumnMobile.Width = 200;
            // 
            // DeleteRowBtn
            // 
            DeleteRowBtn.BackColor = Color.DarkRed;
            DeleteRowBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteRowBtn.ForeColor = SystemColors.ButtonFace;
            DeleteRowBtn.Location = new Point(13, 571);
            DeleteRowBtn.Name = "DeleteRowBtn";
            DeleteRowBtn.Size = new Size(118, 34);
            DeleteRowBtn.TabIndex = 5;
            DeleteRowBtn.Text = "حذف مشتری";
            DeleteRowBtn.UseVisualStyleBackColor = false;
            DeleteRowBtn.Click += DeleteRowBtn_Click;
            // 
            // CreateInvoiceBtn
            // 
            CreateInvoiceBtn.BackColor = Color.FromArgb(0, 0, 192);
            CreateInvoiceBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateInvoiceBtn.ForeColor = SystemColors.Control;
            CreateInvoiceBtn.Location = new Point(619, 571);
            CreateInvoiceBtn.Name = "CreateInvoiceBtn";
            CreateInvoiceBtn.Size = new Size(114, 34);
            CreateInvoiceBtn.TabIndex = 6;
            CreateInvoiceBtn.Text = "صدور فاکتور";
            CreateInvoiceBtn.UseVisualStyleBackColor = false;
            CreateInvoiceBtn.Click += CreateInvoiceBtn_Click;
            // 
            // ShowCustomerInvoiceListBtn
            // 
            ShowCustomerInvoiceListBtn.BackColor = Color.Teal;
            ShowCustomerInvoiceListBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ShowCustomerInvoiceListBtn.ForeColor = SystemColors.ButtonHighlight;
            ShowCustomerInvoiceListBtn.Location = new Point(502, 571);
            ShowCustomerInvoiceListBtn.Name = "ShowCustomerInvoiceListBtn";
            ShowCustomerInvoiceListBtn.Size = new Size(111, 34);
            ShowCustomerInvoiceListBtn.TabIndex = 7;
            ShowCustomerInvoiceListBtn.Text = "لیست فاکتور";
            ShowCustomerInvoiceListBtn.UseVisualStyleBackColor = false;
            ShowCustomerInvoiceListBtn.Click += ShowCustomerInvoiceListBtn_Click;
            // 
            // CustomersFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 616);
            Controls.Add(ShowCustomerInvoiceListBtn);
            Controls.Add(CreateInvoiceBtn);
            Controls.Add(DeleteRowBtn);
            Controls.Add(cutomersGridView);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(createCustomerBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomersFrm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "مشتریان";
            Shown += CustomersFrm_Shown;
            ((System.ComponentModel.ISupportInitialize)cutomersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createCustomerBtn;
        private TextBox textBox1;
        private Label label1;
        private DataGridView cutomersGridView;
        private Button DeleteRowBtn;
        private Button CreateInvoiceBtn;
        private Button ShowCustomerInvoiceListBtn;
        private DataGridViewTextBoxColumn ColumnRowNumber;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnCode;
        private DataGridViewTextBoxColumn ColumnFullName;
        private DataGridViewTextBoxColumn ColumnMobile;
    }
}