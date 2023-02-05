namespace POS_Search
{
    partial class SubCategory_Search
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
            this.pLabel1 = new POS_Control.PLabel();
            this.cboCategory = new POS_Control.PCombo();
            this.pLabel2 = new POS_Control.PLabel();
            this.txtSubCategory = new POS_Control.PTextBox();
            this.dgvSubCategory = new POS_Control.PGridView();
            this.SubCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDisplay = new POS_Control.PButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(35, 80);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(114, 30);
            this.pLabel1.TabIndex = 2;
            this.pLabel1.Text = "အမျိုးအစား";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.IsDatatableOccurs = null;
            this.cboCategory.IsErrorOccurs = false;
            this.cboCategory.Location = new System.Drawing.Point(149, 80);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCategory.MinimumSize = new System.Drawing.Size(114, 0);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.NextControl = null;
            this.cboCategory.NextControlName = null;
            this.cboCategory.Size = new System.Drawing.Size(387, 35);
            this.cboCategory.TabIndex = 4;
            // 
            // pLabel2
            // 
            this.pLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel2.Location = new System.Drawing.Point(38, 135);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(114, 30);
            this.pLabel2.TabIndex = 5;
            this.pLabel2.Text = "အမျိုးအစားခွဲ";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubCategory.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtSubCategory.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubCategory.IsDatatableOccurs = null;
            this.txtSubCategory.IsErrorOccurs = false;
            this.txtSubCategory.Location = new System.Drawing.Point(149, 135);
            this.txtSubCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubCategory.MinimumSize = new System.Drawing.Size(114, 20);
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.NextControl = null;
            this.txtSubCategory.NextControlName = null;
            this.txtSubCategory.SearchType = Entity.SearchType.ScType.None;
            this.txtSubCategory.Size = new System.Drawing.Size(388, 35);
            this.txtSubCategory.TabIndex = 6;
            this.txtSubCategory.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // dgvSubCategory
            // 
            this.dgvSubCategory.AllowUserToAddRows = false;
            this.dgvSubCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubCode,
            this.CategoryName,
            this.SubName});
            this.dgvSubCategory.Location = new System.Drawing.Point(35, 200);
            this.dgvSubCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSubCategory.Name = "dgvSubCategory";
            this.dgvSubCategory.RowHeadersVisible = false;
            this.dgvSubCategory.RowHeadersWidth = 51;
            this.dgvSubCategory.RowTemplate.Height = 25;
            this.dgvSubCategory.Size = new System.Drawing.Size(1051, 600);
            this.dgvSubCategory.TabIndex = 7;
            this.dgvSubCategory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSubCategory_CellMouseDoubleClick);
            // 
            // SubCode
            // 
            this.SubCode.DataPropertyName = "SubCode";
            this.SubCode.HeaderText = "အမျိုးအစားခွဲကုဒ်နံပါတ်";
            this.SubCode.MinimumWidth = 6;
            this.SubCode.Name = "SubCode";
            this.SubCode.ReadOnly = true;
            this.SubCode.Width = 155;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "အမျိုးအစား";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 360;
            // 
            // SubName
            // 
            this.SubName.DataPropertyName = "SubName";
            this.SubName.HeaderText = "အမျိုးအစားခွဲ";
            this.SubName.MinimumWidth = 6;
            this.SubName.Name = "SubName";
            this.SubName.ReadOnly = true;
            this.SubName.Width = 360;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDisplay.ButtonType = Entity.ButtonType.BType.Normal;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplay.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplay.Location = new System.Drawing.Point(571, 135);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(114, 40);
            this.btnDisplay.TabIndex = 8;
            this.btnDisplay.Text = "ပြပါ";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // SubCategory_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 881);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.dgvSubCategory);
            this.Controls.Add(this.txtSubCategory);
            this.Controls.Add(this.pLabel2);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.pLabel1);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "SubCategory_Search";
            this.Text = "SubCategory_Search";
            this.Load += new System.EventHandler(this.SubCategory_Search_Load);
            this.Controls.SetChildIndex(this.pLabel1, 0);
            this.Controls.SetChildIndex(this.cboCategory, 0);
            this.Controls.SetChildIndex(this.pLabel2, 0);
            this.Controls.SetChildIndex(this.txtSubCategory, 0);
            this.Controls.SetChildIndex(this.dgvSubCategory, 0);
            this.Controls.SetChildIndex(this.btnDisplay, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private POS_Control.PLabel pLabel1;
        private POS_Control.PCombo cboCategory;
        private POS_Control.PLabel pLabel2;
        private POS_Control.PTextBox txtSubCategory;
        private POS_Control.PGridView dgvSubCategory;
        private POS_Control.PButton btnDisplay;
        private DataGridViewTextBoxColumn SubCode;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn SubName;
    }
}