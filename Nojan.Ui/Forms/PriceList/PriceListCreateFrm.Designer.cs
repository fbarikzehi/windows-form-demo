namespace Nojan.Ui.Forms.PriceList
{
    partial class PriceListCreateFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceListCreateFrm));
            panel1 = new Panel();
            comboBoxMonth = new ComboBox();
            comboBoxYear = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTitle = new TextBox();
            itemsGridView = new DataGridView();
            ColumnRowCount = new DataGridViewTextBoxColumn();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnTitle = new DataGridViewTextBoxColumn();
            ColumnPrice = new DataGridViewTextBoxColumn();
            ColumnCode = new DataGridViewTextBoxColumn();
            DeleteRowBtn = new Button();
            btnInsertItem = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemsGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxMonth);
            panel1.Controls.Add(comboBoxYear);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTitle);
            panel1.Location = new Point(8, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 60);
            panel1.TabIndex = 0;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Location = new Point(14, 25);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(118, 23);
            comboBoxMonth.TabIndex = 6;
            // 
            // comboBoxYear
            // 
            comboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(138, 25);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(121, 23);
            comboBoxYear.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 7);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 4;
            label3.Text = "ماه:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 7);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "سال:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(743, 7);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "عنوان:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(265, 25);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(513, 23);
            txtTitle.TabIndex = 0;
            // 
            // itemsGridView
            // 
            itemsGridView.AllowUserToAddRows = false;
            itemsGridView.AllowUserToDeleteRows = false;
            itemsGridView.AllowUserToResizeRows = false;
            itemsGridView.BackgroundColor = SystemColors.ActiveCaption;
            itemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnRowCount, ColumnId, ColumnTitle, ColumnPrice, ColumnCode });
            itemsGridView.Location = new Point(8, 76);
            itemsGridView.Name = "itemsGridView";
            itemsGridView.RowTemplate.Height = 25;
            itemsGridView.ScrollBars = ScrollBars.Vertical;
            itemsGridView.Size = new Size(789, 439);
            itemsGridView.TabIndex = 1;
            itemsGridView.TabStop = false;
            itemsGridView.CellFormatting += ServicesGridView_CellFormatting;
            // 
            // ColumnRowCount
            // 
            dataGridViewCellStyle1.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnRowCount.DefaultCellStyle = dataGridViewCellStyle1;
            ColumnRowCount.HeaderText = "ردیف";
            ColumnRowCount.Name = "ColumnRowCount";
            ColumnRowCount.Width = 55;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "#";
            ColumnId.Name = "ColumnId";
            ColumnId.Visible = false;
            // 
            // ColumnTitle
            // 
            dataGridViewCellStyle2.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnTitle.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnTitle.HeaderText = "عنوان";
            ColumnTitle.Name = "ColumnTitle";
            ColumnTitle.Width = 340;
            // 
            // ColumnPrice
            // 
            dataGridViewCellStyle3.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnPrice.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnPrice.HeaderText = "قیمت واحد";
            ColumnPrice.Name = "ColumnPrice";
            ColumnPrice.Width = 200;
            // 
            // ColumnCode
            // 
            dataGridViewCellStyle4.Font = new Font("B Nazanin", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnCode.DefaultCellStyle = dataGridViewCellStyle4;
            ColumnCode.HeaderText = "کد";
            ColumnCode.Name = "ColumnCode";
            ColumnCode.Width = 152;
            // 
            // DeleteRowBtn
            // 
            DeleteRowBtn.BackColor = Color.FromArgb(192, 0, 0);
            DeleteRowBtn.ForeColor = Color.White;
            DeleteRowBtn.Location = new Point(658, 521);
            DeleteRowBtn.Name = "DeleteRowBtn";
            DeleteRowBtn.Size = new Size(139, 33);
            DeleteRowBtn.TabIndex = 2;
            DeleteRowBtn.TabStop = false;
            DeleteRowBtn.Text = "حذف [DEL]";
            DeleteRowBtn.UseVisualStyleBackColor = false;
            DeleteRowBtn.Click += DeleteRowBtn_Click;
            // 
            // btnInsertItem
            // 
            btnInsertItem.BackColor = Color.Teal;
            btnInsertItem.ForeColor = Color.Cornsilk;
            btnInsertItem.Location = new Point(8, 521);
            btnInsertItem.Name = "btnInsertItem";
            btnInsertItem.Size = new Size(139, 33);
            btnInsertItem.TabIndex = 3;
            btnInsertItem.Text = "افزودن آیتم [+]";
            btnInsertItem.UseVisualStyleBackColor = false;
            btnInsertItem.Click += btnInsertItem_Click;
            // 
            // PriceListCreateFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(809, 566);
            Controls.Add(btnInsertItem);
            Controls.Add(DeleteRowBtn);
            Controls.Add(itemsGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PriceListCreateFrm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "تعریف لیست قیمت ";
            Shown += PriceListCreateFrm_Shown;
            KeyDown += PriceListCreateFrm_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtTitle;
        private DataGridView itemsGridView;
        private Button DeleteRowBtn;
        private ComboBox comboBoxYear;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxMonth;
        private DataGridViewTextBoxColumn ColumnRowCount;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnTitle;
        private DataGridViewTextBoxColumn ColumnPrice;
        private DataGridViewTextBoxColumn ColumnCode;
        private Button btnInsertItem;
    }
}