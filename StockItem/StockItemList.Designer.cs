namespace StockItem
{
    partial class StockItemList
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
            this.txtName = new POS_Control.PTextBox();
            this.btnDisplay = new POS_Control.PButton();
            this.dgvStockItem = new POS_Control.PGridView();
            this.pLabel1 = new POS_Control.PLabel();
            this.pLabel2 = new POS_Control.PLabel();
            this.ItemCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PanelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockItem)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDetail
            // 
            this.PanelDetail.Controls.Add(this.cboSubCategory);
            this.PanelDetail.Controls.Add(this.dgvStockItem);
            this.PanelDetail.Controls.Add(this.txtName);
            this.PanelDetail.Controls.Add(this.pLabel1);
            this.PanelDetail.Controls.Add(this.btnDisplay);
            this.PanelDetail.Controls.Add(this.pLabel2);
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
            this.cboSubCategory.Location = new System.Drawing.Point(124, 18);
            this.cboSubCategory.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboSubCategory.Name = "cboSubCategory";
            this.cboSubCategory.NextControl = this.txtName;
            this.cboSubCategory.NextControlName = "txtName";
            this.cboSubCategory.Size = new System.Drawing.Size(311, 29);
            this.cboSubCategory.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.DefaultKeyboard = POS_Control.PTextBox.DefKey.Myanmar;
            this.txtName.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.IsDatatableOccurs = null;
            this.txtName.IsErrorOccurs = false;
            this.txtName.Location = new System.Drawing.Point(578, 17);
            this.txtName.MaxLength = 100;
            this.txtName.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtName.Name = "txtName";
            this.txtName.NextControl = this.btnDisplay;
            this.txtName.NextControlName = "btnDisplay";
            this.txtName.SearchType = Entity.SearchType.ScType.None;
            this.txtName.Size = new System.Drawing.Size(311, 30);
            this.txtName.TabIndex = 20;
            this.txtName.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDisplay.ButtonType = Entity.ButtonType.BType.Normal;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplay.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplay.Location = new System.Drawing.Point(951, 15);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(100, 30);
            this.btnDisplay.TabIndex = 18;
            this.btnDisplay.Text = "ပြပါ";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // dgvStockItem
            // 
            this.dgvStockItem.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCD,
            this.SubName,
            this.ItemName,
            this.Qty,
            this.UOMName,
            this.LastSalePrice,
            this.ReorderQty,
            this.BarCode,
            this.Action});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockItem.Location = new System.Drawing.Point(21, 66);
            this.dgvStockItem.Name = "dgvStockItem";
            this.dgvStockItem.RowHeadersVisible = false;
            this.dgvStockItem.RowTemplate.Height = 25;
            this.dgvStockItem.Size = new System.Drawing.Size(1273, 598);
            this.dgvStockItem.TabIndex = 21;
            this.dgvStockItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockItem_CellContentClick);
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(478, 17);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(100, 30);
            this.pLabel1.TabIndex = 19;
            this.pLabel1.Text = "အမည်";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLabel2
            // 
            this.pLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel2.Location = new System.Drawing.Point(24, 18);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(100, 30);
            this.pLabel2.TabIndex = 17;
            this.pLabel2.Text = "အမျိုးအစားခွဲ";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemCD
            // 
            this.ItemCD.HeaderText = "ကုဒ်နံပါတ်";
            this.ItemCD.Name = "ItemCD";
            this.ItemCD.Visible = false;
            // 
            // SubName
            // 
            this.SubName.HeaderText = "အမျိုးအစားခွဲ";
            this.SubName.Name = "SubName";
            this.SubName.Width = 200;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "အမည်";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 300;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "ပမာဏ";
            this.Qty.Name = "Qty";
            this.Qty.Width = 150;
            // 
            // UOMName
            // 
            this.UOMName.HeaderText = "ယူနစ်";
            this.UOMName.Name = "UOMName";
            this.UOMName.Width = 70;
            // 
            // LastSalePrice
            // 
            this.LastSalePrice.HeaderText = "စျေးနှုန်း";
            this.LastSalePrice.Name = "LastSalePrice";
            this.LastSalePrice.Width = 150;
            // 
            // ReorderQty
            // 
            this.ReorderQty.HeaderText = "အနဲဆုံးလက်ကျန်";
            this.ReorderQty.Name = "ReorderQty";
            this.ReorderQty.Width = 150;
            // 
            // BarCode
            // 
            this.BarCode.HeaderText = "ဘားကုဒ်";
            this.BarCode.Name = "BarCode";
            this.BarCode.Width = 150;
            // 
            // Action
            // 
            this.Action.HeaderText = "ဖျက်ရန်";
            this.Action.Name = "Action";
            this.Action.Text = "ဖျက်ရန်";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // StockItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.PanelDetail);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "StockItemList";
            this.Text = "StockItemList";
            this.Load += new System.EventHandler(this.StockItemList_Load);
            this.Controls.SetChildIndex(this.PanelDetail, 0);
            this.PanelDetail.ResumeLayout(false);
            this.PanelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelDetail;
        private POS_Control.PCombo cboSubCategory;
        private POS_Control.PGridView dgvStockItem;
        private POS_Control.PTextBox txtName;
        private POS_Control.PLabel pLabel1;
        private POS_Control.PButton btnDisplay;
        private POS_Control.PLabel pLabel2;
        private DataGridViewTextBoxColumn ItemCD;
        private DataGridViewTextBoxColumn SubName;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn UOMName;
        private DataGridViewTextBoxColumn LastSalePrice;
        private DataGridViewTextBoxColumn ReorderQty;
        private DataGridViewTextBoxColumn BarCode;
        private DataGridViewButtonColumn Action;
    }
}