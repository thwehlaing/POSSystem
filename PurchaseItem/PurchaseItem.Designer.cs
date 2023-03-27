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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelDetail = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pLabel1 = new POS_Control.PLabel();
            this.cboItemName = new POS_Control.PCombo();
            this.pLabel3 = new POS_Control.PLabel();
            this.cboSubCategory = new POS_Control.PCombo();
            this.txtQtyPerPack = new POS_Control.PTextBox();
            this.btnAdd = new POS_Control.PButton();
            this.pLabel7 = new POS_Control.PLabel();
            this.txtQty = new POS_Control.PTextBox();
            this.txtUOMPrice = new POS_Control.PTextBox();
            this.pLabel9 = new POS_Control.PLabel();
            this.pLabel6 = new POS_Control.PLabel();
            this.cboPackType = new POS_Control.PCombo();
            this.txtPackPrice = new POS_Control.PTextBox();
            this.pLabel2 = new POS_Control.PLabel();
            this.cboSupplier = new POS_Control.PCombo();
            this.pLabel5 = new POS_Control.PLabel();
            this.txtPNo = new POS_Control.PTextBox();
            this.pLabel4 = new POS_Control.PLabel();
            this.dgvPurchaseItem = new POS_Control.PGridView();
            this.pLabel8 = new POS_Control.PLabel();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.ItemCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyPerPack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOMPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseItem)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDetail
            // 
            this.PanelDetail.Controls.Add(this.groupBox1);
            this.PanelDetail.Controls.Add(this.cboSupplier);
            this.PanelDetail.Controls.Add(this.pLabel5);
            this.PanelDetail.Controls.Add(this.txtPNo);
            this.PanelDetail.Controls.Add(this.pLabel4);
            this.PanelDetail.Controls.Add(this.dgvPurchaseItem);
            this.PanelDetail.Controls.Add(this.pLabel8);
            this.PanelDetail.Controls.Add(this.dtpPurchaseDate);
            this.PanelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetail.Location = new System.Drawing.Point(0, 57);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(1924, 939);
            this.PanelDetail.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pLabel1);
            this.groupBox1.Controls.Add(this.cboItemName);
            this.groupBox1.Controls.Add(this.pLabel3);
            this.groupBox1.Controls.Add(this.cboSubCategory);
            this.groupBox1.Controls.Add(this.txtQtyPerPack);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.pLabel7);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.txtUOMPrice);
            this.groupBox1.Controls.Add(this.pLabel9);
            this.groupBox1.Controls.Add(this.pLabel6);
            this.groupBox1.Controls.Add(this.cboPackType);
            this.groupBox1.Controls.Add(this.txtPackPrice);
            this.groupBox1.Controls.Add(this.pLabel2);
            this.groupBox1.Location = new System.Drawing.Point(28, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1255, 167);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.Red;
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(594, 28);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(150, 35);
            this.pLabel1.TabIndex = 113;
            this.pLabel1.Text = "ကုန်ပစ္စည်းအမည်";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboItemName
            // 
            this.cboItemName.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboItemName.FormattingEnabled = true;
            this.cboItemName.IsDatatableOccurs = null;
            this.cboItemName.IsErrorOccurs = false;
            this.cboItemName.Location = new System.Drawing.Point(744, 28);
            this.cboItemName.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.NextControl = null;
            this.cboItemName.NextControlName = "cboCashType";
            this.cboItemName.Size = new System.Drawing.Size(430, 35);
            this.cboItemName.TabIndex = 114;
            // 
            // pLabel3
            // 
            this.pLabel3.BackColor = System.Drawing.Color.Red;
            this.pLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel3.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel3.Location = new System.Drawing.Point(17, 27);
            this.pLabel3.Name = "pLabel3";
            this.pLabel3.Size = new System.Drawing.Size(150, 35);
            this.pLabel3.TabIndex = 115;
            this.pLabel3.Text = "အမျိုးအစား(ခွဲ)";
            this.pLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboSubCategory
            // 
            this.cboSubCategory.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSubCategory.FormattingEnabled = true;
            this.cboSubCategory.IsDatatableOccurs = null;
            this.cboSubCategory.IsErrorOccurs = false;
            this.cboSubCategory.Location = new System.Drawing.Point(167, 27);
            this.cboSubCategory.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboSubCategory.Name = "cboSubCategory";
            this.cboSubCategory.NextControl = null;
            this.cboSubCategory.NextControlName = "cboItemName";
            this.cboSubCategory.Size = new System.Drawing.Size(400, 35);
            this.cboSubCategory.TabIndex = 116;
            this.cboSubCategory.SelectedIndexChanged += new System.EventHandler(this.cboSubCategory_SelectedIndexChanged);
            // 
            // txtQtyPerPack
            // 
            this.txtQtyPerPack.AllowMinus = false;
            this.txtQtyPerPack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtQtyPerPack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtyPerPack.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtQtyPerPack.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtyPerPack.IsDatatableOccurs = null;
            this.txtQtyPerPack.IsErrorOccurs = false;
            this.txtQtyPerPack.Location = new System.Drawing.Point(467, 70);
            this.txtQtyPerPack.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtQtyPerPack.Name = "txtQtyPerPack";
            this.txtQtyPerPack.NextControl = null;
            this.txtQtyPerPack.NextControlName = "txtUOMPrice";
            this.txtQtyPerPack.ReadOnly = true;
            this.txtQtyPerPack.SearchType = Entity.SearchType.ScType.None;
            this.txtQtyPerPack.Size = new System.Drawing.Size(100, 35);
            this.txtQtyPerPack.TabIndex = 122;
            this.txtQtyPerPack.TextBoxType = POS_Control.PTextBox.PTextBoxType.Number;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.ButtonType = Entity.ButtonType.BType.Normal;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(351, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 40);
            this.btnAdd.TabIndex = 140;
            this.btnAdd.Text = "ထည့်မည်";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pLabel7
            // 
            this.pLabel7.BackColor = System.Drawing.Color.Red;
            this.pLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel7.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel7.Location = new System.Drawing.Point(15, 115);
            this.pLabel7.Name = "pLabel7";
            this.pLabel7.Size = new System.Drawing.Size(150, 35);
            this.pLabel7.TabIndex = 123;
            this.pLabel7.Text = "၁ခုစျေး";
            this.pLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQty
            // 
            this.txtQty.AllowMinus = false;
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtQty.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQty.IsDatatableOccurs = null;
            this.txtQty.IsErrorOccurs = false;
            this.txtQty.Location = new System.Drawing.Point(744, 69);
            this.txtQty.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtQty.Name = "txtQty";
            this.txtQty.NextControl = null;
            this.txtQty.NextControlName = "txtPackPrice";
            this.txtQty.SearchType = Entity.SearchType.ScType.None;
            this.txtQty.Size = new System.Drawing.Size(126, 35);
            this.txtQty.TabIndex = 139;
            this.txtQty.TextBoxType = POS_Control.PTextBox.PTextBoxType.Number;
            // 
            // txtUOMPrice
            // 
            this.txtUOMPrice.AllowMinus = false;
            this.txtUOMPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUOMPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUOMPrice.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtUOMPrice.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUOMPrice.IsDatatableOccurs = null;
            this.txtUOMPrice.IsErrorOccurs = false;
            this.txtUOMPrice.Location = new System.Drawing.Point(165, 115);
            this.txtUOMPrice.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtUOMPrice.Name = "txtUOMPrice";
            this.txtUOMPrice.NextControl = null;
            this.txtUOMPrice.NextControlName = "txtPackQty";
            this.txtUOMPrice.ReadOnly = true;
            this.txtUOMPrice.SearchType = Entity.SearchType.ScType.None;
            this.txtUOMPrice.Size = new System.Drawing.Size(165, 35);
            this.txtUOMPrice.TabIndex = 124;
            this.txtUOMPrice.TextBoxType = POS_Control.PTextBox.PTextBoxType.Price;
            // 
            // pLabel9
            // 
            this.pLabel9.BackColor = System.Drawing.Color.Red;
            this.pLabel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel9.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel9.Location = new System.Drawing.Point(595, 69);
            this.pLabel9.Name = "pLabel9";
            this.pLabel9.Size = new System.Drawing.Size(150, 35);
            this.pLabel9.TabIndex = 138;
            this.pLabel9.Text = "အရေအတွက်";
            this.pLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLabel6
            // 
            this.pLabel6.BackColor = System.Drawing.Color.Red;
            this.pLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel6.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel6.Location = new System.Drawing.Point(884, 69);
            this.pLabel6.Name = "pLabel6";
            this.pLabel6.Size = new System.Drawing.Size(150, 35);
            this.pLabel6.TabIndex = 133;
            this.pLabel6.Text = "အထုပ်စျေးနှုန်း";
            this.pLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboPackType
            // 
            this.cboPackType.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPackType.FormattingEnabled = true;
            this.cboPackType.IsDatatableOccurs = null;
            this.cboPackType.IsErrorOccurs = false;
            this.cboPackType.Location = new System.Drawing.Point(161, 70);
            this.cboPackType.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboPackType.Name = "cboPackType";
            this.cboPackType.NextControl = null;
            this.cboPackType.NextControlName = "txtPackPrice";
            this.cboPackType.Size = new System.Drawing.Size(306, 35);
            this.cboPackType.TabIndex = 137;
            this.cboPackType.SelectedIndexChanged += new System.EventHandler(this.cboPackType_SelectedIndexChanged);
            // 
            // txtPackPrice
            // 
            this.txtPackPrice.AllowMinus = false;
            this.txtPackPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackPrice.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtPackPrice.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPackPrice.IsDatatableOccurs = null;
            this.txtPackPrice.IsErrorOccurs = false;
            this.txtPackPrice.Location = new System.Drawing.Point(1033, 69);
            this.txtPackPrice.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtPackPrice.Name = "txtPackPrice";
            this.txtPackPrice.NextControl = null;
            this.txtPackPrice.NextControlName = "btnAdd";
            this.txtPackPrice.SearchType = Entity.SearchType.ScType.None;
            this.txtPackPrice.Size = new System.Drawing.Size(141, 35);
            this.txtPackPrice.TabIndex = 134;
            this.txtPackPrice.TextBoxType = POS_Control.PTextBox.PTextBoxType.Price;
            this.txtPackPrice.Enter += new System.EventHandler(this.txtPackPrice_Enter);
            // 
            // pLabel2
            // 
            this.pLabel2.BackColor = System.Drawing.Color.Red;
            this.pLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel2.Location = new System.Drawing.Point(15, 70);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(150, 35);
            this.pLabel2.TabIndex = 136;
            this.pLabel2.Text = "ထုပ်ပိုးမှုပုံစံ";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboSupplier
            // 
            this.cboSupplier.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.IsDatatableOccurs = null;
            this.cboSupplier.IsErrorOccurs = false;
            this.cboSupplier.Location = new System.Drawing.Point(882, 21);
            this.cboSupplier.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.NextControl = null;
            this.cboSupplier.NextControlName = "cboCashType";
            this.cboSupplier.Size = new System.Drawing.Size(320, 35);
            this.cboSupplier.TabIndex = 144;
            // 
            // pLabel5
            // 
            this.pLabel5.BackColor = System.Drawing.Color.Red;
            this.pLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel5.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel5.Location = new System.Drawing.Point(732, 21);
            this.pLabel5.Name = "pLabel5";
            this.pLabel5.Size = new System.Drawing.Size(150, 35);
            this.pLabel5.TabIndex = 143;
            this.pLabel5.Text = "ဆိုင်အမည်";
            this.pLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPNo
            // 
            this.txtPNo.AllowMinus = false;
            this.txtPNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPNo.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtPNo.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPNo.IsDatatableOccurs = null;
            this.txtPNo.IsErrorOccurs = false;
            this.txtPNo.Location = new System.Drawing.Point(194, 22);
            this.txtPNo.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtPNo.Name = "txtPNo";
            this.txtPNo.NextControl = null;
            this.txtPNo.NextControlName = "txtPackPrice";
            this.txtPNo.SearchType = Entity.SearchType.ScType.None;
            this.txtPNo.Size = new System.Drawing.Size(165, 35);
            this.txtPNo.TabIndex = 142;
            this.txtPNo.TextBoxType = POS_Control.PTextBox.PTextBoxType.Number;
            // 
            // pLabel4
            // 
            this.pLabel4.BackColor = System.Drawing.Color.Red;
            this.pLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel4.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel4.Location = new System.Drawing.Point(44, 22);
            this.pLabel4.Name = "pLabel4";
            this.pLabel4.Size = new System.Drawing.Size(150, 35);
            this.pLabel4.TabIndex = 141;
            this.pLabel4.Text = "ကုဒ်နံပါတ်";
            this.pLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPurchaseItem
            // 
            this.dgvPurchaseItem.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCD,
            this.PackTypeCode,
            this.ItemName,
            this.PackTypeName,
            this.QtyPerPack,
            this.PackPrice,
            this.UOMPrice,
            this.Qty});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchaseItem.Location = new System.Drawing.Point(28, 248);
            this.dgvPurchaseItem.Name = "dgvPurchaseItem";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPurchaseItem.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvPurchaseItem.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPurchaseItem.RowTemplate.Height = 35;
            this.dgvPurchaseItem.Size = new System.Drawing.Size(1255, 547);
            this.dgvPurchaseItem.TabIndex = 135;
            // 
            // pLabel8
            // 
            this.pLabel8.BackColor = System.Drawing.Color.Red;
            this.pLabel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel8.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel8.Location = new System.Drawing.Point(378, 22);
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
            this.dtpPurchaseDate.Location = new System.Drawing.Point(527, 22);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(184, 35);
            this.dtpPurchaseDate.TabIndex = 125;
            // 
            // ItemCD
            // 
            this.ItemCD.HeaderText = "ItemCD";
            this.ItemCD.Name = "ItemCD";
            this.ItemCD.Visible = false;
            // 
            // PackTypeCode
            // 
            this.PackTypeCode.HeaderText = "PackTypeCode";
            this.PackTypeCode.Name = "PackTypeCode";
            this.PackTypeCode.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ကုန်ပစ္စည်းအမည်";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 300;
            // 
            // PackTypeName
            // 
            this.PackTypeName.HeaderText = "ထုပ်ပိုးမှုပုံစံ";
            this.PackTypeName.Name = "PackTypeName";
            this.PackTypeName.Width = 300;
            // 
            // QtyPerPack
            // 
            this.QtyPerPack.HeaderText = "အထုပ်ပါအရေအတွက်";
            this.QtyPerPack.Name = "QtyPerPack";
            this.QtyPerPack.Width = 200;
            // 
            // PackPrice
            // 
            this.PackPrice.HeaderText = "အထုပ်စျေး";
            this.PackPrice.Name = "PackPrice";
            this.PackPrice.Width = 150;
            // 
            // UOMPrice
            // 
            this.UOMPrice.HeaderText = "တစ်ခုချင်းစျေး";
            this.UOMPrice.Name = "UOMPrice";
            this.UOMPrice.Width = 150;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "ပမာဏ";
            this.Qty.Name = "Qty";
            this.Qty.Width = 150;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelDetail;
        private POS_Control.PLabel pLabel8;
        private DateTimePicker dtpPurchaseDate;
        private POS_Control.PTextBox txtQtyPerPack;
        private POS_Control.PCombo cboSubCategory;
        private POS_Control.PLabel pLabel3;
        private POS_Control.PCombo cboItemName;
        private POS_Control.PLabel pLabel1;
        private POS_Control.PTextBox txtPackPrice;
        private POS_Control.PLabel pLabel6;
        private POS_Control.PGridView dgvPurchaseItem;
        private POS_Control.PTextBox txtQty;
        private POS_Control.PLabel pLabel9;
        private POS_Control.PCombo cboPackType;
        private POS_Control.PLabel pLabel2;
        private POS_Control.PTextBox txtUOMPrice;
        private POS_Control.PLabel pLabel7;
        private POS_Control.PButton btnAdd;
        private POS_Control.PTextBox txtPNo;
        private POS_Control.PLabel pLabel4;
        private POS_Control.PCombo cboSupplier;
        private POS_Control.PLabel pLabel5;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn ItemCD;
        private DataGridViewTextBoxColumn PackTypeCode;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn PackTypeName;
        private DataGridViewTextBoxColumn QtyPerPack;
        private DataGridViewTextBoxColumn PackPrice;
        private DataGridViewTextBoxColumn UOMPrice;
        private DataGridViewTextBoxColumn Qty;
    }
}