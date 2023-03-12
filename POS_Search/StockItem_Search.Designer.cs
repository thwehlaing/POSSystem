namespace POS_Search
{
    partial class StockItem_Search
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
            this.btnDisplay = new POS_Control.PButton();
            this.pLabel2 = new POS_Control.PLabel();
            this.pLabel1 = new POS_Control.PLabel();
            this.txtName = new POS_Control.PTextBox();
            this.dgvStockItem = new POS_Control.PGridView();
            this.ItemCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOMCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubName = new POS_Control.PTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDisplay.ButtonType = Entity.ButtonType.BType.Normal;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplay.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplay.Location = new System.Drawing.Point(488, 88);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(100, 30);
            this.btnDisplay.TabIndex = 11;
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
            this.pLabel2.Location = new System.Drawing.Point(15, 52);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(100, 30);
            this.pLabel2.TabIndex = 9;
            this.pLabel2.Text = "အမျိုးအစားခွဲ";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(15, 90);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(100, 30);
            this.pLabel1.TabIndex = 13;
            this.pLabel1.Text = "အမည်";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.DefaultKeyboard = POS_Control.PTextBox.DefKey.Myanmar;
            this.txtName.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.IsDatatableOccurs = null;
            this.txtName.IsErrorOccurs = false;
            this.txtName.Location = new System.Drawing.Point(115, 90);
            this.txtName.MaxLength = 100;
            this.txtName.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtName.Name = "txtName";
            this.txtName.NextControl = this.btnDisplay;
            this.txtName.NextControlName = "btnDisplay";
            this.txtName.SearchType = Entity.SearchType.ScType.None;
            this.txtName.Size = new System.Drawing.Size(311, 30);
            this.txtName.TabIndex = 14;
            this.txtName.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
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
            this.UOMCD});
            this.dgvStockItem.Location = new System.Drawing.Point(12, 132);
            this.dgvStockItem.Name = "dgvStockItem";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockItem.RowHeadersVisible = false;
            this.dgvStockItem.RowTemplate.Height = 25;
            this.dgvStockItem.Size = new System.Drawing.Size(860, 479);
            this.dgvStockItem.TabIndex = 15;
            this.dgvStockItem.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockItem_CellContentDoubleClick);
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
            this.SubName.Width = 150;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "အမည်";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 250;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "ပမာဏ";
            this.Qty.Name = "Qty";
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
            // 
            // ReorderQty
            // 
            this.ReorderQty.HeaderText = "အနဲဆုံးလက်ကျန်";
            this.ReorderQty.Name = "ReorderQty";
            // 
            // BarCode
            // 
            this.BarCode.HeaderText = "ဘားကုဒ်";
            this.BarCode.Name = "BarCode";
            // 
            // UOMCD
            // 
            this.UOMCD.HeaderText = "UOMCD";
            this.UOMCD.Name = "UOMCD";
            this.UOMCD.Visible = false;
            // 
            // txtSubName
            // 
            this.txtSubName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubName.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtSubName.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubName.IsDatatableOccurs = null;
            this.txtSubName.IsErrorOccurs = false;
            this.txtSubName.Location = new System.Drawing.Point(115, 52);
            this.txtSubName.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.NextControl = null;
            this.txtSubName.NextControlName = null;
            this.txtSubName.ReadOnly = true;
            this.txtSubName.SearchType = Entity.SearchType.ScType.None;
            this.txtSubName.Size = new System.Drawing.Size(311, 30);
            this.txtSubName.TabIndex = 16;
            this.txtSubName.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // StockItem_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.txtSubName);
            this.Controls.Add(this.dgvStockItem);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pLabel1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.pLabel2);
            this.Name = "StockItem_Search";
            this.Text = "StockItem_Search";
            this.Load += new System.EventHandler(this.StockItem_Search_Load);
            this.Controls.SetChildIndex(this.pLabel2, 0);
            this.Controls.SetChildIndex(this.btnDisplay, 0);
            this.Controls.SetChildIndex(this.pLabel1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.dgvStockItem, 0);
            this.Controls.SetChildIndex(this.txtSubName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private POS_Control.PButton btnDisplay;
        private POS_Control.PLabel pLabel2;
        private POS_Control.PLabel pLabel1;
        private POS_Control.PTextBox txtName;
        private POS_Control.PGridView dgvStockItem;
        private POS_Control.PTextBox txtSubName;
        private DataGridViewTextBoxColumn ItemCD;
        private DataGridViewTextBoxColumn SubName;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn UOMName;
        private DataGridViewTextBoxColumn LastSalePrice;
        private DataGridViewTextBoxColumn ReorderQty;
        private DataGridViewTextBoxColumn BarCode;
        private DataGridViewTextBoxColumn UOMCD;
    }
}