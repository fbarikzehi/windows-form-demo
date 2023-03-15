namespace Nojan.Ui.Forms.Invoice
{
    partial class InvoiceCreateFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceCreateFrm));
            panel1 = new Panel();
            BtnAddProject = new Button();
            ComboCustomerProject = new ComboBox();
            label3 = new Label();
            lblCode = new Label();
            lblFullName = new Label();
            label2 = new Label();
            label1 = new Label();
            lblInvoiceNumber = new Label();
            label4 = new Label();
            invoiceItemsGridView = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnRowCount = new Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
            ColumnItemName = new Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewLabelXColumn();
            ColumnQty = new DataGridViewTextBoxColumn();
            ColumnUnit = new DataGridViewComboBoxColumn();
            ColumnUnitPrice = new Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewLabelXColumn();
            ColumnTotalPrice = new Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewLabelXColumn();
            InvoicePrintBtn = new Button();
            panel3 = new Panel();
            lblTotalPrice = new Label();
            label10 = new Label();
            DeleteItemBtn = new Button();
            SelectItemsBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)invoiceItemsGridView).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(BtnAddProject);
            panel1.Controls.Add(ComboCustomerProject);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblCode);
            panel1.Controls.Add(lblFullName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(9, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 38);
            panel1.TabIndex = 0;
            // 
            // BtnAddProject
            // 
            BtnAddProject.BackColor = SystemColors.ActiveCaption;
            BtnAddProject.FlatAppearance.BorderColor = Color.Silver;
            BtnAddProject.FlatAppearance.BorderSize = 0;
            BtnAddProject.FlatStyle = FlatStyle.Flat;
            BtnAddProject.Location = new Point(3, 6);
            BtnAddProject.Name = "BtnAddProject";
            BtnAddProject.Size = new Size(98, 24);
            BtnAddProject.TabIndex = 12;
            BtnAddProject.Text = "افزودن پروژه";
            BtnAddProject.TextAlign = ContentAlignment.TopCenter;
            BtnAddProject.UseVisualStyleBackColor = false;
            BtnAddProject.Click += BtnAddProject_Click;
            // 
            // ComboCustomerProject
            // 
            ComboCustomerProject.BackColor = SystemColors.InactiveBorder;
            ComboCustomerProject.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboCustomerProject.FormattingEnabled = true;
            ComboCustomerProject.Location = new Point(102, 6);
            ComboCustomerProject.MaxDropDownItems = 100;
            ComboCustomerProject.Name = "ComboCustomerProject";
            ComboCustomerProject.Size = new Size(215, 23);
            ComboCustomerProject.TabIndex = 13;
            ComboCustomerProject.TabStop = false;
            ComboCustomerProject.SelectionChangeCommitted += ComboCustomerProject_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 9);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 12;
            label3.Text = "پروژه:";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(422, 9);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(0, 15);
            lblCode.TabIndex = 1;
            lblCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(656, 9);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(0, 15);
            lblFullName.TabIndex = 1;
            lblFullName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(503, 9);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "کد مشتری: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(726, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "مشتری: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.BackColor = Color.LightSkyBlue;
            lblInvoiceNumber.Location = new Point(653, 9);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(0, 15);
            lblInvoiceNumber.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSkyBlue;
            label4.Location = new Point(708, 9);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "شماره فاکتور:";
            // 
            // invoiceItemsGridView
            // 
            invoiceItemsGridView.AllowUserToAddRows = false;
            invoiceItemsGridView.AllowUserToDeleteRows = false;
            invoiceItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            invoiceItemsGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnRowCount, ColumnItemName, ColumnQty, ColumnUnit, ColumnUnitPrice, ColumnTotalPrice });
            invoiceItemsGridView.Location = new Point(9, 45);
            invoiceItemsGridView.Name = "invoiceItemsGridView";
            invoiceItemsGridView.RowTemplate.Height = 25;
            invoiceItemsGridView.ScrollBars = ScrollBars.Vertical;
            invoiceItemsGridView.Size = new Size(784, 477);
            invoiceItemsGridView.TabIndex = 8;
            invoiceItemsGridView.TabStop = false;
            invoiceItemsGridView.CellFormatting += invoiceItemsGridView_CellFormatting;
            invoiceItemsGridView.CellValueChanged += invoiceItemsGridView_CellValueChanged;
            invoiceItemsGridView.CurrentCellDirtyStateChanged += invoiceItemsGridView_CurrentCellDirtyStateChanged;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "#";
            ColumnId.Name = "ColumnId";
            ColumnId.Visible = false;
            // 
            // ColumnRowCount
            // 
            ColumnRowCount.BackColor = SystemColors.Window;
            // 
            // 
            // 
            ColumnRowCount.BackgroundStyle.Class = "DataGridViewBorder";
            ColumnRowCount.BackgroundStyle.CornerType = Stimulsoft.Controls.Win.DotNetBar.eCornerType.Square;
            ColumnRowCount.Culture = new System.Globalization.CultureInfo("en-US");
            dataGridViewCellStyle1.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnRowCount.DefaultCellStyle = dataGridViewCellStyle1;
            ColumnRowCount.ForeColor = SystemColors.ControlText;
            ColumnRowCount.HeaderText = "ردیف";
            ColumnRowCount.ImeMode = ImeMode.NoControl;
            ColumnRowCount.Mask = "";
            ColumnRowCount.Name = "ColumnRowCount";
            ColumnRowCount.PasswordChar = '\0';
            ColumnRowCount.Resizable = DataGridViewTriState.True;
            ColumnRowCount.RightToLeft = RightToLeft.No;
            ColumnRowCount.Text = "";
            ColumnRowCount.Width = 60;
            // 
            // ColumnItemName
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnItemName.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnItemName.HeaderText = "شرح";
            ColumnItemName.Name = "ColumnItemName";
            ColumnItemName.Resizable = DataGridViewTriState.True;
            ColumnItemName.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnItemName.Width = 302;
            // 
            // ColumnQty
            // 
            ColumnQty.HeaderText = "مقدار";
            ColumnQty.Name = "ColumnQty";
            ColumnQty.Width = 60;
            // 
            // ColumnUnit
            // 
            dataGridViewCellStyle3.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnUnit.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnUnit.HeaderText = "واحد";
            ColumnUnit.Name = "ColumnUnit";
            ColumnUnit.Resizable = DataGridViewTriState.True;
            ColumnUnit.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnUnit.Width = 60;
            // 
            // ColumnUnitPrice
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnUnitPrice.DefaultCellStyle = dataGridViewCellStyle4;
            ColumnUnitPrice.HeaderText = "قیمت واحد (ریال)";
            ColumnUnitPrice.Name = "ColumnUnitPrice";
            ColumnUnitPrice.Resizable = DataGridViewTriState.True;
            ColumnUnitPrice.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnUnitPrice.Width = 130;
            // 
            // ColumnTotalPrice
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnTotalPrice.DefaultCellStyle = dataGridViewCellStyle5;
            ColumnTotalPrice.HeaderText = "قیمت کل (ریال)";
            ColumnTotalPrice.Name = "ColumnTotalPrice";
            ColumnTotalPrice.Resizable = DataGridViewTriState.True;
            ColumnTotalPrice.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnTotalPrice.Width = 130;
            // 
            // InvoicePrintBtn
            // 
            InvoicePrintBtn.BackColor = SystemColors.HotTrack;
            InvoicePrintBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            InvoicePrintBtn.ForeColor = SystemColors.ButtonHighlight;
            InvoicePrintBtn.Location = new Point(9, 568);
            InvoicePrintBtn.Name = "InvoicePrintBtn";
            InvoicePrintBtn.Size = new Size(144, 40);
            InvoicePrintBtn.TabIndex = 9;
            InvoicePrintBtn.Text = "پرینت فاکتور [Ctrl + P ]";
            InvoicePrintBtn.UseVisualStyleBackColor = false;
            InvoicePrintBtn.Click += InvoicePrintBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(lblTotalPrice);
            panel3.Controls.Add(lblInvoiceNumber);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(9, 528);
            panel3.Name = "panel3";
            panel3.Size = new Size(784, 34);
            panel3.TabIndex = 10;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(57, 9);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(0, 15);
            lblTotalPrice.TabIndex = 11;
            lblTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(151, 9);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 0;
            label10.Text = "جمع کل (ریال): ";
            // 
            // DeleteItemBtn
            // 
            DeleteItemBtn.BackColor = Color.Maroon;
            DeleteItemBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteItemBtn.ForeColor = Color.Cornsilk;
            DeleteItemBtn.Location = new Point(665, 568);
            DeleteItemBtn.Name = "DeleteItemBtn";
            DeleteItemBtn.Size = new Size(128, 40);
            DeleteItemBtn.TabIndex = 11;
            DeleteItemBtn.Text = "حذف آیتم  [DEL]";
            DeleteItemBtn.UseVisualStyleBackColor = false;
            DeleteItemBtn.Click += DeleteItemBtn_Click;
            // 
            // SelectItemsBtn
            // 
            SelectItemsBtn.BackColor = Color.Teal;
            SelectItemsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectItemsBtn.ForeColor = SystemColors.ControlLight;
            SelectItemsBtn.Location = new Point(535, 568);
            SelectItemsBtn.Name = "SelectItemsBtn";
            SelectItemsBtn.Size = new Size(124, 40);
            SelectItemsBtn.TabIndex = 12;
            SelectItemsBtn.Text = "افزودن آیتم [+]";
            SelectItemsBtn.UseVisualStyleBackColor = false;
            SelectItemsBtn.Click += SelectItemsBtn_Click;
            // 
            // InvoiceCreateFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(803, 616);
            Controls.Add(SelectItemsBtn);
            Controls.Add(DeleteItemBtn);
            Controls.Add(panel3);
            Controls.Add(InvoicePrintBtn);
            Controls.Add(invoiceItemsGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InvoiceCreateFrm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "صدور فاکتور جدید";
            Shown += CreateInvoiceFrm_Shown;
            KeyDown += InvoiceCreateFrm_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)invoiceItemsGridView).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblCode;
        private Label lblFullName;
        private Label label2;
        private DataGridView invoiceItemsGridView;
        private Label lblInvoiceNumber;
        private Label label4;
        private Button InvoicePrintBtn;
        private Panel panel3;
        private Label label10;
        private Label lblTotalPrice;
        private Button DeleteItemBtn;
        private Label label3;
        private ComboBox ComboCustomerProject;
        private Button BtnAddProject;
        private Button button1;
        private Button SelectItemsBtn;
        private DataGridViewTextBoxColumn ColumnId;
        private Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn ColumnRowCount;
        private Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewLabelXColumn ColumnItemName;
        private DataGridViewTextBoxColumn ColumnQty;
        private DataGridViewComboBoxColumn ColumnUnit;
        private Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewLabelXColumn ColumnUnitPrice;
        private Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewLabelXColumn ColumnTotalPrice;
    }
}