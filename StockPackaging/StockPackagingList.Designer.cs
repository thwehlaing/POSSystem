namespace StockPackaging
{
    partial class StockPackagingList
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
            this.cboSubCategory = new POS_Control.PCombo();
            this.pLabel3 = new POS_Control.PLabel();
            this.btnDisplay = new POS_Control.PButton();
            this.cboStockItem = new POS_Control.PCombo();
            this.pLabel1 = new POS_Control.PLabel();
            this.dgvStockPackaging = new POS_Control.PGridView();
            this.ItemCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PanelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockPackaging)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDetail
            // 
            this.PanelDetail.Controls.Add(this.cboSubCategory);
            this.PanelDetail.Controls.Add(this.pLabel3);
            this.PanelDetail.Controls.Add(this.btnDisplay);
            this.PanelDetail.Controls.Add(this.cboStockItem);
            this.PanelDetail.Controls.Add(this.pLabel1);
            this.PanelDetail.Controls.Add(this.dgvStockPackaging);
            this.PanelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetail.Location = new System.Drawing.Point(0, 57);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(1924, 939);
            this.PanelDetail.TabIndex = 40;
            // 
            // cboSubCategory
            // 
            this.cboSubCategory.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSubCategory.FormattingEnabled = true;
            this.cboSubCategory.IsDatatableOccurs = null;
            this.cboSubCategory.IsErrorOccurs = false;
            this.cboSubCategory.Location = new System.Drawing.Point(122, 17);
            this.cboSubCategory.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboSubCategory.Name = "cboSubCategory";
            this.cboSubCategory.NextControl = this.cboStockItem;
            this.cboSubCategory.NextControlName = "cboItemName";
            this.cboSubCategory.Size = new System.Drawing.Size(322, 29);
            this.cboSubCategory.TabIndex = 82;
            this.cboSubCategory.SelectedIndexChanged += new System.EventHandler(this.cboSubCategory_SelectedIndexChanged);
            // 
            // pLabel3
            // 
            this.pLabel3.BackColor = System.Drawing.Color.LightCyan;
            this.pLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel3.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel3.Location = new System.Drawing.Point(22, 17);
            this.pLabel3.Name = "pLabel3";
            this.pLabel3.Size = new System.Drawing.Size(100, 30);
            this.pLabel3.TabIndex = 81;
            this.pLabel3.Text = "အမျိုးအစား(ခွဲ)";
            this.pLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDisplay.ButtonType = Entity.ButtonType.BType.Normal;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplay.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplay.Location = new System.Drawing.Point(937, 15);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(102, 30);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "ပြမည်";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // cboStockItem
            // 
            this.cboStockItem.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboStockItem.FormattingEnabled = true;
            this.cboStockItem.IsDatatableOccurs = null;
            this.cboStockItem.IsErrorOccurs = false;
            this.cboStockItem.Location = new System.Drawing.Point(580, 15);
            this.cboStockItem.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboStockItem.Name = "cboStockItem";
            this.cboStockItem.NextControl = this.btnDisplay;
            this.cboStockItem.NextControlName = "btnDisplay";
            this.cboStockItem.Size = new System.Drawing.Size(322, 29);
            this.cboStockItem.TabIndex = 2;
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(480, 15);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(100, 30);
            this.pLabel1.TabIndex = 1;
            this.pLabel1.Text = "ကုန်ပစ္စည်းအမည်";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvStockPackaging
            // 
            this.dgvStockPackaging.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockPackaging.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockPackaging.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockPackaging.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCD,
            this.PackTypeCode,
            this.PackQty,
            this.OpenQty,
            this.btnEdit,
            this.btnDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockPackaging.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockPackaging.Location = new System.Drawing.Point(21, 57);
            this.dgvStockPackaging.Name = "dgvStockPackaging";
            this.dgvStockPackaging.RowHeadersVisible = false;
            this.dgvStockPackaging.RowTemplate.Height = 25;
            this.dgvStockPackaging.Size = new System.Drawing.Size(1203, 716);
            this.dgvStockPackaging.TabIndex = 0;
            this.dgvStockPackaging.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockPackaging_CellContentClick);
            // 
            // ItemCD
            // 
            this.ItemCD.HeaderText = "ကုန်ပစ္စည်းကုဒ်နံပါတ်";
            this.ItemCD.Name = "ItemCD";
            this.ItemCD.ReadOnly = true;
            this.ItemCD.Width = 250;
            // 
            // PackTypeCode
            // 
            this.PackTypeCode.HeaderText = "အထုပ်အမျိုးအစား ကုဒ်နံပါတ်";
            this.PackTypeCode.Name = "PackTypeCode";
            this.PackTypeCode.ReadOnly = true;
            this.PackTypeCode.Width = 250;
            // 
            // PackQty
            // 
            this.PackQty.HeaderText = "ပမာဏ";
            this.PackQty.Name = "PackQty";
            this.PackQty.Width = 200;
            // 
            // OpenQty
            // 
            this.OpenQty.HeaderText = "အဖွင့်ပမာဏ";
            this.OpenQty.Name = "OpenQty";
            this.OpenQty.ReadOnly = true;
            this.OpenQty.Width = 200;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "ပြင်ဆင်ရန်";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEdit.Text = "ပြင်ဆင်ရန်";
            this.btnEdit.Width = 150;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "ပယ်ဖျက်ရန်";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDelete.Text = "ပယ်ဖျက်ရန်";
            this.btnDelete.Width = 150;
            // 
            // StockPackagingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.PanelDetail);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "StockPackagingList";
            this.Text = "StockPackagingList";
            this.Load += new System.EventHandler(this.StockPackagingList_Load);
            this.Controls.SetChildIndex(this.PanelDetail, 0);
            this.PanelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockPackaging)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelDetail;
        private POS_Control.PGridView dgvStockPackaging;
        private POS_Control.PCombo cboStockItem;
        private POS_Control.PLabel pLabel1;
        private POS_Control.PButton btnDisplay;
        private POS_Control.PCombo cboSubCategory;
        private POS_Control.PLabel pLabel3;
        private DataGridViewTextBoxColumn ItemCD;
        private DataGridViewTextBoxColumn PackTypeCode;
        private DataGridViewTextBoxColumn PackQty;
        private DataGridViewTextBoxColumn OpenQty;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
    }
}