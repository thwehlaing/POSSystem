namespace SubCategory
{
    partial class SubCategoryList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelDetail = new System.Windows.Forms.Panel();
            this.txtSubName = new POS_Control.PTextBox();
            this.dgvSubcategory = new POS_Control.PGridView();
            this.SubCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDisplay = new POS_Control.PButton();
            this.pLabel2 = new POS_Control.PLabel();
            this.cboCategory = new POS_Control.PCombo();
            this.pLabel1 = new POS_Control.PLabel();
            this.PanelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcategory)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDetail
            // 
            this.PanelDetail.Controls.Add(this.txtSubName);
            this.PanelDetail.Controls.Add(this.dgvSubcategory);
            this.PanelDetail.Controls.Add(this.btnDisplay);
            this.PanelDetail.Controls.Add(this.pLabel2);
            this.PanelDetail.Controls.Add(this.cboCategory);
            this.PanelDetail.Controls.Add(this.pLabel1);
            this.PanelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetail.Location = new System.Drawing.Point(0, 57);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(1924, 895);
            this.PanelDetail.TabIndex = 40;
            // 
            // txtSubName
            // 
            this.txtSubName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubName.DefaultKeyboard = POS_Control.PTextBox.DefKey.Myanmar;
            this.txtSubName.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubName.IsDatatableOccurs = null;
            this.txtSubName.IsErrorOccurs = false;
            this.txtSubName.Location = new System.Drawing.Point(558, 19);
            this.txtSubName.MaxLength = 50;
            this.txtSubName.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.NextControl = null;
            this.txtSubName.NextControlName = "btnDisplay";
            this.txtSubName.SearchType = Entity.SearchType.ScType.None;
            this.txtSubName.Size = new System.Drawing.Size(307, 30);
            this.txtSubName.TabIndex = 52;
            this.txtSubName.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // dgvSubcategory
            // 
            this.dgvSubcategory.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubcategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubcategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubCode,
            this.CategoryName,
            this.SubName,
            this.Action});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubcategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubcategory.Location = new System.Drawing.Point(29, 68);
            this.dgvSubcategory.Name = "dgvSubcategory";
            this.dgvSubcategory.RowHeadersVisible = false;
            this.dgvSubcategory.RowTemplate.Height = 25;
            this.dgvSubcategory.Size = new System.Drawing.Size(1433, 628);
            this.dgvSubcategory.TabIndex = 51;
            this.dgvSubcategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubcategory_CellContentClick);
            // 
            // SubCode
            // 
            this.SubCode.DataPropertyName = "SubCode";
            this.SubCode.HeaderText = "အမျိုးအစားခွဲကုဒ်နံပါတ်";
            this.SubCode.Name = "SubCode";
            this.SubCode.Width = 300;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "အမျိုးအစား";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Width = 500;
            // 
            // SubName
            // 
            this.SubName.DataPropertyName = "SubName";
            this.SubName.HeaderText = "အမျိုးအစားခွဲ";
            this.SubName.Name = "SubName";
            this.SubName.Width = 500;
            // 
            // Action
            // 
            this.Action.DataPropertyName = "SubCatgoryCD";
            this.Action.HeaderText = "လုပ်ဆောင်ချက်";
            this.Action.Name = "Action";
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action.Text = "ဖျက်ရန်";
            this.Action.UseColumnTextForButtonValue = true;
            this.Action.Width = 130;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDisplay.ButtonType = Entity.ButtonType.BType.Normal;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplay.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplay.Location = new System.Drawing.Point(884, 17);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(115, 29);
            this.btnDisplay.TabIndex = 50;
            this.btnDisplay.Text = "ပြပါ";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // pLabel2
            // 
            this.pLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel2.Location = new System.Drawing.Point(458, 19);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(100, 30);
            this.pLabel2.TabIndex = 49;
            this.pLabel2.Text = "အမျိုးအစား(ခွဲ)";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.IsDatatableOccurs = null;
            this.cboCategory.IsErrorOccurs = false;
            this.cboCategory.Location = new System.Drawing.Point(132, 19);
            this.cboCategory.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.NextControl = null;
            this.cboCategory.NextControlName = "txtSubName";
            this.cboCategory.Size = new System.Drawing.Size(300, 29);
            this.cboCategory.TabIndex = 48;
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(32, 19);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(100, 30);
            this.pLabel1.TabIndex = 47;
            this.pLabel1.Text = "အမျိုးအစား";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubCategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1017);
            this.Controls.Add(this.PanelDetail);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "SubCategoryList";
            this.Text = "SubCategoryList";
            this.Load += new System.EventHandler(this.SubCategoryList_Load);
            this.Controls.SetChildIndex(this.PanelDetail, 0);
            this.PanelDetail.ResumeLayout(false);
            this.PanelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelDetail;
        private POS_Control.PTextBox txtSubName;
        private POS_Control.PGridView dgvSubcategory;
        private POS_Control.PButton btnDisplay;
        private POS_Control.PLabel pLabel2;
        private POS_Control.PCombo cboCategory;
        private POS_Control.PLabel pLabel1;
        private DataGridViewTextBoxColumn SubCode;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn SubName;
        private DataGridViewButtonColumn Action;
    }
}