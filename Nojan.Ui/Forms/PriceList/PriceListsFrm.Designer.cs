namespace Nojan.Ui.Forms.PriceList
{
    partial class PriceListsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceListsFrm));
            PriceListGridView = new DataGridView();
            ColumnRowNumber = new DataGridViewTextBoxColumn();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnTitle = new DataGridViewTextBoxColumn();
            ColumnYear = new DataGridViewTextBoxColumn();
            ColumnMonth = new DataGridViewTextBoxColumn();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            CreateBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PriceListGridView).BeginInit();
            SuspendLayout();
            // 
            // PriceListGridView
            // 
            PriceListGridView.AllowUserToAddRows = false;
            PriceListGridView.AllowUserToDeleteRows = false;
            PriceListGridView.AllowUserToResizeRows = false;
            PriceListGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PriceListGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnRowNumber, ColumnId, ColumnTitle, ColumnYear, ColumnMonth });
            PriceListGridView.Location = new Point(12, 35);
            PriceListGridView.Name = "PriceListGridView";
            PriceListGridView.RowTemplate.Height = 25;
            PriceListGridView.ScrollBars = ScrollBars.Vertical;
            PriceListGridView.Size = new Size(603, 469);
            PriceListGridView.TabIndex = 0;
            PriceListGridView.TabStop = false;
            PriceListGridView.CellFormatting += PriceListGridView_CellFormatting;
            // 
            // ColumnRowNumber
            // 
            ColumnRowNumber.HeaderText = "ردیف";
            ColumnRowNumber.Name = "ColumnRowNumber";
            ColumnRowNumber.ReadOnly = true;
            ColumnRowNumber.Resizable = DataGridViewTriState.False;
            ColumnRowNumber.Width = 60;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "#";
            ColumnId.Name = "ColumnId";
            ColumnId.Visible = false;
            // 
            // ColumnTitle
            // 
            ColumnTitle.HeaderText = "عنوان";
            ColumnTitle.Name = "ColumnTitle";
            ColumnTitle.ReadOnly = true;
            ColumnTitle.Width = 300;
            // 
            // ColumnYear
            // 
            ColumnYear.HeaderText = "سال";
            ColumnYear.Name = "ColumnYear";
            ColumnYear.ReadOnly = true;
            // 
            // ColumnMonth
            // 
            ColumnMonth.HeaderText = "ماه";
            ColumnMonth.Name = "ColumnMonth";
            ColumnMonth.ReadOnly = true;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Aquamarine;
            UpdateBtn.Location = new Point(12, 510);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(105, 39);
            UpdateBtn.TabIndex = 2;
            UpdateBtn.Text = "ویرایش";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Crimson;
            DeleteBtn.Location = new Point(510, 510);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(105, 39);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "حذف";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.DeepSkyBlue;
            CreateBtn.Location = new Point(123, 510);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(105, 39);
            CreateBtn.TabIndex = 4;
            CreateBtn.Text = "ثبت جدید";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // PriceListsFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 561);
            Controls.Add(CreateBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(PriceListGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PriceListsFrm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "لیست قیمت ها";
            Shown += PriceListsFrm_Shown;
            ((System.ComponentModel.ISupportInitialize)PriceListGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PriceListGridView;
        private DataGridViewTextBoxColumn ColumnRowNumber;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnTitle;
        private DataGridViewTextBoxColumn ColumnYear;
        private DataGridViewTextBoxColumn ColumnMonth;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button CreateBtn;
    }
}