namespace PurchaseItem
{
    partial class PurchaseItem
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
            this.PanelDetail = new System.Windows.Forms.Panel();
            this.txtPackPrice = new POS_Control.PTextBox();
            this.pLabel6 = new POS_Control.PLabel();
            this.txtPackQty = new POS_Control.PTextBox();
            this.pLabel9 = new POS_Control.PLabel();
            this.pLabel8 = new POS_Control.PLabel();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtUOMPrice = new POS_Control.PTextBox();
            this.pLabel7 = new POS_Control.PLabel();
            this.txtUOMQty = new POS_Control.PTextBox();
            this.pLabel5 = new POS_Control.PLabel();
            this.cboTradeType = new POS_Control.PCombo();
            this.pLabel4 = new POS_Control.PLabel();
            this.cboCashType = new POS_Control.PCombo();
            this.pLabel2 = new POS_Control.PLabel();
            this.cboSubCategory = new POS_Control.PCombo();
            this.pLabel3 = new POS_Control.PLabel();
            this.cboItemName = new POS_Control.PCombo();
            this.pLabel1 = new POS_Control.PLabel();
            this.PanelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDetail
            // 
            this.PanelDetail.Controls.Add(this.txtPackPrice);
            this.PanelDetail.Controls.Add(this.pLabel6);
            this.PanelDetail.Controls.Add(this.txtPackQty);
            this.PanelDetail.Controls.Add(this.pLabel9);
            this.PanelDetail.Controls.Add(this.pLabel8);
            this.PanelDetail.Controls.Add(this.dtpPurchaseDate);
            this.PanelDetail.Controls.Add(this.txtUOMPrice);
            this.PanelDetail.Controls.Add(this.pLabel7);
            this.PanelDetail.Controls.Add(this.txtUOMQty);
            this.PanelDetail.Controls.Add(this.pLabel5);
            this.PanelDetail.Controls.Add(this.cboTradeType);
            this.PanelDetail.Controls.Add(this.pLabel4);
            this.PanelDetail.Controls.Add(this.cboCashType);
            this.PanelDetail.Controls.Add(this.pLabel2);
            this.PanelDetail.Controls.Add(this.cboSubCategory);
            this.PanelDetail.Controls.Add(this.pLabel3);
            this.PanelDetail.Controls.Add(this.cboItemName);
            this.PanelDetail.Controls.Add(this.pLabel1);
            this.PanelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetail.Location = new System.Drawing.Point(0, 57);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(1924, 939);
            this.PanelDetail.TabIndex = 40;
            // 
            // txtPackPrice
            // 
            this.txtPackPrice.AllowMinus = false;
            this.txtPackPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackPrice.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtPackPrice.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPackPrice.IsDatatableOccurs = null;
            this.txtPackPrice.IsErrorOccurs = false;
            this.txtPackPrice.Location = new System.Drawing.Point(171, 315);
            this.txtPackPrice.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtPackPrice.Name = "txtPackPrice";
            this.txtPackPrice.NextControl = null;
            this.txtPackPrice.NextControlName = "dtpSaleDate";
            this.txtPackPrice.SearchType = Entity.SearchType.ScType.None;
            this.txtPackPrice.Size = new System.Drawing.Size(187, 35);
            this.txtPackPrice.TabIndex = 130;
            this.txtPackPrice.TextBoxType = POS_Control.PTextBox.PTextBoxType.Price;
            // 
            // pLabel6
            // 
            this.pLabel6.BackColor = System.Drawing.Color.Red;
            this.pLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel6.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel6.Location = new System.Drawing.Point(22, 315);
            this.pLabel6.Name = "pLabel6";
            this.pLabel6.Size = new System.Drawing.Size(150, 35);
            this.pLabel6.TabIndex = 129;
            this.pLabel6.Text = "စျေးနှုန်း(အထုပ်)";
            this.pLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPackQty
            // 
            this.txtPackQty.AllowMinus = false;
            this.txtPackQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackQty.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtPackQty.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPackQty.IsDatatableOccurs = null;
            this.txtPackQty.IsErrorOccurs = false;
            this.txtPackQty.Location = new System.Drawing.Point(171, 272);
            this.txtPackQty.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtPackQty.Name = "txtPackQty";
            this.txtPackQty.NextControl = null;
            this.txtPackQty.NextControlName = "txtPackPrice";
            this.txtPackQty.SearchType = Entity.SearchType.ScType.None;
            this.txtPackQty.Size = new System.Drawing.Size(187, 35);
            this.txtPackQty.TabIndex = 128;
            this.txtPackQty.TextBoxType = POS_Control.PTextBox.PTextBoxType.Number;
            // 
            // pLabel9
            // 
            this.pLabel9.BackColor = System.Drawing.Color.Red;
            this.pLabel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel9.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel9.Location = new System.Drawing.Point(22, 273);
            this.pLabel9.Name = "pLabel9";
            this.pLabel9.Size = new System.Drawing.Size(150, 35);
            this.pLabel9.TabIndex = 127;
            this.pLabel9.Text = "ပမာဏ(အထုပ်)";
            this.pLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLabel8
            // 
            this.pLabel8.BackColor = System.Drawing.Color.Red;
            this.pLabel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel8.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel8.Location = new System.Drawing.Point(22, 359);
            this.pLabel8.Name = "pLabel8";
            this.pLabel8.Size = new System.Drawing.Size(149, 35);
            this.pLabel8.TabIndex = 126;
            this.pLabel8.Text = "ရက်စွဲ";
            this.pLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.CalendarFont = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpPurchaseDate.Location = new System.Drawing.Point(171, 359);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(184, 35);
            this.dtpPurchaseDate.TabIndex = 125;
            // 
            // txtUOMPrice
            // 
            this.txtUOMPrice.AllowMinus = false;
            this.txtUOMPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUOMPrice.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtUOMPrice.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUOMPrice.IsDatatableOccurs = null;
            this.txtUOMPrice.IsErrorOccurs = false;
            this.txtUOMPrice.Location = new System.Drawing.Point(171, 230);
            this.txtUOMPrice.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtUOMPrice.Name = "txtUOMPrice";
            this.txtUOMPrice.NextControl = null;
            this.txtUOMPrice.NextControlName = "txtPackQty";
            this.txtUOMPrice.SearchType = Entity.SearchType.ScType.None;
            this.txtUOMPrice.Size = new System.Drawing.Size(187, 35);
            this.txtUOMPrice.TabIndex = 124;
            this.txtUOMPrice.TextBoxType = POS_Control.PTextBox.PTextBoxType.Price;
            // 
            // pLabel7
            // 
            this.pLabel7.BackColor = System.Drawing.Color.Red;
            this.pLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel7.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel7.Location = new System.Drawing.Point(22, 231);
            this.pLabel7.Name = "pLabel7";
            this.pLabel7.Size = new System.Drawing.Size(150, 35);
            this.pLabel7.TabIndex = 123;
            this.pLabel7.Text = "စျေးနှုန်း(၁ခု)";
            this.pLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUOMQty
            // 
            this.txtUOMQty.AllowMinus = false;
            this.txtUOMQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUOMQty.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtUOMQty.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUOMQty.IsDatatableOccurs = null;
            this.txtUOMQty.IsErrorOccurs = false;
            this.txtUOMQty.Location = new System.Drawing.Point(171, 189);
            this.txtUOMQty.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtUOMQty.Name = "txtUOMQty";
            this.txtUOMQty.NextControl = null;
            this.txtUOMQty.NextControlName = "txtUOMPrice";
            this.txtUOMQty.SearchType = Entity.SearchType.ScType.None;
            this.txtUOMQty.Size = new System.Drawing.Size(187, 35);
            this.txtUOMQty.TabIndex = 122;
            this.txtUOMQty.TextBoxType = POS_Control.PTextBox.PTextBoxType.Number;
            // 
            // pLabel5
            // 
            this.pLabel5.BackColor = System.Drawing.Color.Red;
            this.pLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel5.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel5.Location = new System.Drawing.Point(21, 189);
            this.pLabel5.Name = "pLabel5";
            this.pLabel5.Size = new System.Drawing.Size(150, 35);
            this.pLabel5.TabIndex = 121;
            this.pLabel5.Text = "ပမာဏ(၁ခု)";
            this.pLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboTradeType
            // 
            this.cboTradeType.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTradeType.FormattingEnabled = true;
            this.cboTradeType.IsDatatableOccurs = null;
            this.cboTradeType.IsErrorOccurs = false;
            this.cboTradeType.Location = new System.Drawing.Point(171, 147);
            this.cboTradeType.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboTradeType.Name = "cboTradeType";
            this.cboTradeType.NextControl = null;
            this.cboTradeType.NextControlName = "txtUOMQty";
            this.cboTradeType.Size = new System.Drawing.Size(322, 35);
            this.cboTradeType.TabIndex = 120;
            // 
            // pLabel4
            // 
            this.pLabel4.BackColor = System.Drawing.Color.Red;
            this.pLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel4.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel4.Location = new System.Drawing.Point(21, 147);
            this.pLabel4.Name = "pLabel4";
            this.pLabel4.Size = new System.Drawing.Size(150, 35);
            this.pLabel4.TabIndex = 119;
            this.pLabel4.Text = "ပေးချေမှု အမျိုးအစား";
            this.pLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCashType
            // 
            this.cboCashType.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCashType.FormattingEnabled = true;
            this.cboCashType.IsDatatableOccurs = null;
            this.cboCashType.IsErrorOccurs = false;
            this.cboCashType.Location = new System.Drawing.Point(171, 105);
            this.cboCashType.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboCashType.Name = "cboCashType";
            this.cboCashType.NextControl = null;
            this.cboCashType.NextControlName = "cboTradeType";
            this.cboCashType.Size = new System.Drawing.Size(322, 35);
            this.cboCashType.TabIndex = 118;
            // 
            // pLabel2
            // 
            this.pLabel2.BackColor = System.Drawing.Color.Red;
            this.pLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel2.Location = new System.Drawing.Point(21, 105);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(150, 35);
            this.pLabel2.TabIndex = 117;
            this.pLabel2.Text = "အ၀ယ် အမျိုးအစား";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboSubCategory
            // 
            this.cboSubCategory.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSubCategory.FormattingEnabled = true;
            this.cboSubCategory.IsDatatableOccurs = null;
            this.cboSubCategory.IsErrorOccurs = false;
            this.cboSubCategory.Location = new System.Drawing.Point(171, 22);
            this.cboSubCategory.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboSubCategory.Name = "cboSubCategory";
            this.cboSubCategory.NextControl = null;
            this.cboSubCategory.NextControlName = "cboItemName";
            this.cboSubCategory.Size = new System.Drawing.Size(322, 35);
            this.cboSubCategory.TabIndex = 116;
            // 
            // pLabel3
            // 
            this.pLabel3.BackColor = System.Drawing.Color.Red;
            this.pLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel3.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel3.Location = new System.Drawing.Point(21, 22);
            this.pLabel3.Name = "pLabel3";
            this.pLabel3.Size = new System.Drawing.Size(150, 35);
            this.pLabel3.TabIndex = 115;
            this.pLabel3.Text = "အမျိုးအစား(ခွဲ)";
            this.pLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboItemName
            // 
            this.cboItemName.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboItemName.FormattingEnabled = true;
            this.cboItemName.IsDatatableOccurs = null;
            this.cboItemName.IsErrorOccurs = false;
            this.cboItemName.Location = new System.Drawing.Point(171, 64);
            this.cboItemName.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.NextControl = null;
            this.cboItemName.NextControlName = "cboCashType";
            this.cboItemName.Size = new System.Drawing.Size(322, 35);
            this.cboItemName.TabIndex = 114;
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.Red;
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(21, 64);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(150, 35);
            this.pLabel1.TabIndex = 113;
            this.pLabel1.Text = "ကုန်ပစ္စည်းအမည်";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PurchaseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.PanelDetail);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "PurchaseItem";
            this.Text = "PurchaseItem";
            this.Load += new System.EventHandler(this.PurchaseItem_Load);
            this.Controls.SetChildIndex(this.PanelDetail, 0);
            this.PanelDetail.ResumeLayout(false);
            this.PanelDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelDetail;
        private POS_Control.PTextBox txtPackPrice;
        private POS_Control.PLabel pLabel6;
        private POS_Control.PTextBox txtPackQty;
        private POS_Control.PLabel pLabel9;
        private POS_Control.PLabel pLabel8;
        private DateTimePicker dtpPurchaseDate;
        private POS_Control.PTextBox txtUOMPrice;
        private POS_Control.PLabel pLabel7;
        private POS_Control.PTextBox txtUOMQty;
        private POS_Control.PLabel pLabel5;
        private POS_Control.PCombo cboTradeType;
        private POS_Control.PLabel pLabel4;
        private POS_Control.PCombo cboCashType;
        private POS_Control.PLabel pLabel2;
        private POS_Control.PCombo cboSubCategory;
        private POS_Control.PLabel pLabel3;
        private POS_Control.PCombo cboItemName;
        private POS_Control.PLabel pLabel1;
    }
}