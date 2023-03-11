namespace POS_Search
{
    partial class Supplier_Search
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
            this.btnDisplay = new POS_Control.PButton();
            this.txtSubCategory = new POS_Control.PTextBox();
            this.pLabel2 = new POS_Control.PLabel();
            this.dgvSupplier = new POS_Control.PGridView();
            this.SupplierCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDisplay.ButtonType = Entity.ButtonType.BType.Normal;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplay.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplay.Location = new System.Drawing.Point(482, 65);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(100, 30);
            this.btnDisplay.TabIndex = 11;
            this.btnDisplay.Text = "ပြပါ";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubCategory.DefaultKeyboard = POS_Control.PTextBox.DefKey.Myanmar;
            this.txtSubCategory.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubCategory.IsDatatableOccurs = null;
            this.txtSubCategory.IsErrorOccurs = false;
            this.txtSubCategory.Location = new System.Drawing.Point(112, 65);
            this.txtSubCategory.MaxLength = 50;
            this.txtSubCategory.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.NextControl = this.btnDisplay;
            this.txtSubCategory.NextControlName = "btnDisplay";
            this.txtSubCategory.SearchType = Entity.SearchType.ScType.None;
            this.txtSubCategory.Size = new System.Drawing.Size(300, 30);
            this.txtSubCategory.TabIndex = 10;
            this.txtSubCategory.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel2
            // 
            this.pLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel2.Location = new System.Drawing.Point(15, 65);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(100, 30);
            this.pLabel2.TabIndex = 9;
            this.pLabel2.Text = "ထောက်ပံ့သူ";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierCD,
            this.SupplierName,
            this.PhoneNo,
            this.Address});
            this.dgvSupplier.Location = new System.Drawing.Point(15, 117);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersVisible = false;
            this.dgvSupplier.RowTemplate.Height = 25;
            this.dgvSupplier.Size = new System.Drawing.Size(850, 478);
            this.dgvSupplier.TabIndex = 12;
            this.dgvSupplier.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSupplier_CellMouseDoubleClick);
            // 
            // SupplierCD
            // 
            this.SupplierCD.DataPropertyName = "SupplierCD";
            this.SupplierCD.HeaderText = "ကုဒ်နံပါတ်";
            this.SupplierCD.Name = "SupplierCD";
            this.SupplierCD.Visible = false;
            this.SupplierCD.Width = 150;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "အမည်";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Width = 200;
            // 
            // PhoneNo
            // 
            this.PhoneNo.DataPropertyName = "PhoneNo";
            this.PhoneNo.HeaderText = "ဖုန်းနံပါတ်";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Width = 200;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "လိပ်စာ";
            this.Address.Name = "Address";
            this.Address.Width = 445;
            // 
            // Supplier_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtSubCategory);
            this.Controls.Add(this.pLabel2);
            this.Name = "Supplier_Search";
            this.Text = "Supplier_Search";
            this.Load += new System.EventHandler(this.Supplier_Search_Load);
            this.Controls.SetChildIndex(this.pLabel2, 0);
            this.Controls.SetChildIndex(this.txtSubCategory, 0);
            this.Controls.SetChildIndex(this.btnDisplay, 0);
            this.Controls.SetChildIndex(this.dgvSupplier, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private POS_Control.PButton btnDisplay;
        private POS_Control.PTextBox txtSubCategory;
        private POS_Control.PLabel pLabel2;
        private POS_Control.PGridView dgvSupplier;
        private DataGridViewTextBoxColumn SupplierCD;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn PhoneNo;
        private DataGridViewTextBoxColumn Address;
    }
}