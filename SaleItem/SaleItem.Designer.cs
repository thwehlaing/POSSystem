namespace SaleItem
{
    partial class SaleItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pLabel8 = new POS_Control.PLabel();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new POS_Control.PTextBox();
            this.pLabel7 = new POS_Control.PLabel();
            this.cboUOM = new POS_Control.PCombo();
            this.pLabel6 = new POS_Control.PLabel();
            this.txtQty = new POS_Control.PTextBox();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDetail
            // 
            this.PanelDetail.Controls.Add(this.panel1);
            this.PanelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetail.Location = new System.Drawing.Point(0, 57);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(1924, 939);
            this.PanelDetail.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pLabel8);
            this.panel1.Controls.Add(this.dtpSaleDate);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.pLabel7);
            this.panel1.Controls.Add(this.cboUOM);
            this.panel1.Controls.Add(this.pLabel6);
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.pLabel5);
            this.panel1.Controls.Add(this.cboTradeType);
            this.panel1.Controls.Add(this.pLabel4);
            this.panel1.Controls.Add(this.cboCashType);
            this.panel1.Controls.Add(this.pLabel2);
            this.panel1.Controls.Add(this.cboSubCategory);
            this.panel1.Controls.Add(this.pLabel3);
            this.panel1.Controls.Add(this.cboItemName);
            this.panel1.Controls.Add(this.pLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 939);
            this.panel1.TabIndex = 0;
            // 
            // pLabel8
            // 
            this.pLabel8.BackColor = System.Drawing.Color.Red;
            this.pLabel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel8.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel8.Location = new System.Drawing.Point(22, 299);
            this.pLabel8.Name = "pLabel8";
            this.pLabel8.Size = new System.Drawing.Size(125, 30);
            this.pLabel8.TabIndex = 108;
            this.pLabel8.Text = "ရက်စွဲ";
            this.pLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.CalendarFont = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpSaleDate.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpSaleDate.Location = new System.Drawing.Point(147, 299);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(155, 32);
            this.dtpSaleDate.TabIndex = 107;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtPrice.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.IsDatatableOccurs = null;
            this.txtPrice.IsErrorOccurs = false;
            this.txtPrice.Location = new System.Drawing.Point(147, 258);
            this.txtPrice.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.NextControl = this.dtpSaleDate;
            this.txtPrice.NextControlName = "dtpSaleDate";
            this.txtPrice.SearchType = Entity.SearchType.ScType.None;
            this.txtPrice.Size = new System.Drawing.Size(187, 30);
            this.txtPrice.TabIndex = 106;
            this.txtPrice.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel7
            // 
            this.pLabel7.BackColor = System.Drawing.Color.Red;
            this.pLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel7.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel7.Location = new System.Drawing.Point(23, 258);
            this.pLabel7.Name = "pLabel7";
            this.pLabel7.Size = new System.Drawing.Size(124, 30);
            this.pLabel7.TabIndex = 105;
            this.pLabel7.Text = "စျေးနှုန်း";
            this.pLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboUOM
            // 
            this.cboUOM.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboUOM.FormattingEnabled = true;
            this.cboUOM.IsDatatableOccurs = null;
            this.cboUOM.IsErrorOccurs = false;
            this.cboUOM.Location = new System.Drawing.Point(145, 219);
            this.cboUOM.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboUOM.Name = "cboUOM";
            this.cboUOM.NextControl = this.txtPrice;
            this.cboUOM.NextControlName = "txtPrice";
            this.cboUOM.Size = new System.Drawing.Size(189, 29);
            this.cboUOM.TabIndex = 104;
            // 
            // pLabel6
            // 
            this.pLabel6.BackColor = System.Drawing.Color.Red;
            this.pLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel6.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel6.Location = new System.Drawing.Point(23, 219);
            this.pLabel6.Name = "pLabel6";
            this.pLabel6.Size = new System.Drawing.Size(122, 30);
            this.pLabel6.TabIndex = 103;
            this.pLabel6.Text = "ယူနစ်";
            this.pLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtQty.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQty.IsDatatableOccurs = null;
            this.txtQty.IsErrorOccurs = false;
            this.txtQty.Location = new System.Drawing.Point(147, 180);
            this.txtQty.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtQty.Name = "txtQty";
            this.txtQty.NextControl = this.cboUOM;
            this.txtQty.NextControlName = "cboUOM";
            this.txtQty.SearchType = Entity.SearchType.ScType.None;
            this.txtQty.Size = new System.Drawing.Size(187, 30);
            this.txtQty.TabIndex = 102;
            this.txtQty.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel5
            // 
            this.pLabel5.BackColor = System.Drawing.Color.Red;
            this.pLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel5.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel5.Location = new System.Drawing.Point(23, 180);
            this.pLabel5.Name = "pLabel5";
            this.pLabel5.Size = new System.Drawing.Size(124, 30);
            this.pLabel5.TabIndex = 101;
            this.pLabel5.Text = "ပမာဏ";
            this.pLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboTradeType
            // 
            this.cboTradeType.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTradeType.FormattingEnabled = true;
            this.cboTradeType.IsDatatableOccurs = null;
            this.cboTradeType.IsErrorOccurs = false;
            this.cboTradeType.Location = new System.Drawing.Point(147, 141);
            this.cboTradeType.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboTradeType.Name = "cboTradeType";
            this.cboTradeType.NextControl = this.txtQty;
            this.cboTradeType.NextControlName = "txtQty";
            this.cboTradeType.Size = new System.Drawing.Size(322, 29);
            this.cboTradeType.TabIndex = 100;
            // 
            // pLabel4
            // 
            this.pLabel4.BackColor = System.Drawing.Color.Red;
            this.pLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel4.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel4.Location = new System.Drawing.Point(25, 141);
            this.pLabel4.Name = "pLabel4";
            this.pLabel4.Size = new System.Drawing.Size(122, 30);
            this.pLabel4.TabIndex = 99;
            this.pLabel4.Text = "ပေးချေမှု အမျိုးအစား";
            this.pLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCashType
            // 
            this.cboCashType.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCashType.FormattingEnabled = true;
            this.cboCashType.IsDatatableOccurs = null;
            this.cboCashType.IsErrorOccurs = false;
            this.cboCashType.Location = new System.Drawing.Point(147, 104);
            this.cboCashType.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboCashType.Name = "cboCashType";
            this.cboCashType.NextControl = this.cboTradeType;
            this.cboCashType.NextControlName = "cboTradeType";
            this.cboCashType.Size = new System.Drawing.Size(322, 29);
            this.cboCashType.TabIndex = 98;
            // 
            // pLabel2
            // 
            this.pLabel2.BackColor = System.Drawing.Color.Red;
            this.pLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel2.Location = new System.Drawing.Point(25, 103);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(122, 30);
            this.pLabel2.TabIndex = 97;
            this.pLabel2.Text = "အရောင်း အမျိုးအစား";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboSubCategory
            // 
            this.cboSubCategory.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSubCategory.FormattingEnabled = true;
            this.cboSubCategory.IsDatatableOccurs = null;
            this.cboSubCategory.IsErrorOccurs = false;
            this.cboSubCategory.Location = new System.Drawing.Point(147, 27);
            this.cboSubCategory.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboSubCategory.Name = "cboSubCategory";
            this.cboSubCategory.NextControl = this.cboItemName;
            this.cboSubCategory.NextControlName = "cboItemName";
            this.cboSubCategory.Size = new System.Drawing.Size(322, 29);
            this.cboSubCategory.TabIndex = 96;
            this.cboSubCategory.SelectedIndexChanged += new System.EventHandler(this.cboSubCategory_SelectedIndexChanged);
            // 
            // pLabel3
            // 
            this.pLabel3.BackColor = System.Drawing.Color.Red;
            this.pLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel3.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel3.Location = new System.Drawing.Point(25, 27);
            this.pLabel3.Name = "pLabel3";
            this.pLabel3.Size = new System.Drawing.Size(122, 30);
            this.pLabel3.TabIndex = 95;
            this.pLabel3.Text = "အမျိုးအစား(ခွဲ)";
            this.pLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboItemName
            // 
            this.cboItemName.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboItemName.FormattingEnabled = true;
            this.cboItemName.IsDatatableOccurs = null;
            this.cboItemName.IsErrorOccurs = false;
            this.cboItemName.Location = new System.Drawing.Point(147, 65);
            this.cboItemName.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.NextControl = this.cboCashType;
            this.cboItemName.NextControlName = "cboCashType";
            this.cboItemName.Size = new System.Drawing.Size(322, 29);
            this.cboItemName.TabIndex = 94;
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.Red;
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(25, 65);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(122, 30);
            this.pLabel1.TabIndex = 93;
            this.pLabel1.Text = "ကုန်ပစ္စည်းအမည်";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaleItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.PanelDetail);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "SaleItem";
            this.Text = "SaleItem";
            this.Load += new System.EventHandler(this.SaleItem_Load);
            this.Controls.SetChildIndex(this.PanelDetail, 0);
            this.PanelDetail.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelDetail;
        private Panel panel1;
        private POS_Control.PLabel pLabel8;
        private DateTimePicker dtpSaleDate;
        private POS_Control.PTextBox txtPrice;
        private POS_Control.PLabel pLabel7;
        private POS_Control.PCombo cboUOM;
        private POS_Control.PLabel pLabel6;
        private POS_Control.PTextBox txtQty;
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