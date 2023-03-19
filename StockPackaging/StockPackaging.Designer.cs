namespace StockPackaging
{
    partial class StockPackaging
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
            this.cboSubCategory = new POS_Control.PCombo();
            this.cboItemName = new POS_Control.PCombo();
            this.cboPackagingType = new POS_Control.PCombo();
            this.txtQty = new POS_Control.PTextBox();
            this.pLabel3 = new POS_Control.PLabel();
            this.pLabel4 = new POS_Control.PLabel();
            this.pLabel2 = new POS_Control.PLabel();
            this.pLabel1 = new POS_Control.PLabel();
            this.PanelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDetail
            // 
            this.PanelDetail.Controls.Add(this.cboSubCategory);
            this.PanelDetail.Controls.Add(this.pLabel3);
            this.PanelDetail.Controls.Add(this.txtQty);
            this.PanelDetail.Controls.Add(this.pLabel4);
            this.PanelDetail.Controls.Add(this.cboPackagingType);
            this.PanelDetail.Controls.Add(this.pLabel2);
            this.PanelDetail.Controls.Add(this.cboItemName);
            this.PanelDetail.Controls.Add(this.pLabel1);
            this.PanelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetail.Location = new System.Drawing.Point(0, 57);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(1924, 939);
            this.PanelDetail.TabIndex = 40;
            // 
            // cboSubCategory
            // 
            this.cboSubCategory.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSubCategory.FormattingEnabled = true;
            this.cboSubCategory.IsDatatableOccurs = null;
            this.cboSubCategory.IsErrorOccurs = false;
            this.cboSubCategory.Location = new System.Drawing.Point(144, 23);
            this.cboSubCategory.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboSubCategory.Name = "cboSubCategory";
            this.cboSubCategory.NextControl = this.cboItemName;
            this.cboSubCategory.NextControlName = "cboItemName";
            this.cboSubCategory.Size = new System.Drawing.Size(322, 35);
            this.cboSubCategory.TabIndex = 80;
            this.cboSubCategory.SelectedIndexChanged += new System.EventHandler(this.cboSubCategory_SelectedIndexChanged);
            // 
            // cboItemName
            // 
            this.cboItemName.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboItemName.FormattingEnabled = true;
            this.cboItemName.IsDatatableOccurs = null;
            this.cboItemName.IsErrorOccurs = false;
            this.cboItemName.Location = new System.Drawing.Point(144, 61);
            this.cboItemName.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.NextControl = this.cboPackagingType;
            this.cboItemName.NextControlName = "cboPackagingType";
            this.cboItemName.Size = new System.Drawing.Size(322, 35);
            this.cboItemName.TabIndex = 58;
            // 
            // cboPackagingType
            // 
            this.cboPackagingType.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPackagingType.FormattingEnabled = true;
            this.cboPackagingType.IsDatatableOccurs = null;
            this.cboPackagingType.IsErrorOccurs = false;
            this.cboPackagingType.Location = new System.Drawing.Point(144, 101);
            this.cboPackagingType.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboPackagingType.Name = "cboPackagingType";
            this.cboPackagingType.NextControl = this.txtQty;
            this.cboPackagingType.NextControlName = "txtQty";
            this.cboPackagingType.Size = new System.Drawing.Size(322, 35);
            this.cboPackagingType.TabIndex = 60;
            // 
            // txtQty
            // 
            this.txtQty.AllowMinus = false;
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtQty.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQty.IsDatatableOccurs = null;
            this.txtQty.IsErrorOccurs = false;
            this.txtQty.Location = new System.Drawing.Point(144, 142);
            this.txtQty.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtQty.Name = "txtQty";
            this.txtQty.NextControl = null;
            this.txtQty.NextControlName = "BtnF2";
            this.txtQty.SearchType = Entity.SearchType.ScType.None;
            this.txtQty.Size = new System.Drawing.Size(187, 35);
            this.txtQty.TabIndex = 71;
            this.txtQty.TextBoxType = POS_Control.PTextBox.PTextBoxType.Number;
            // 
            // pLabel3
            // 
            this.pLabel3.BackColor = System.Drawing.Color.Red;
            this.pLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel3.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel3.Location = new System.Drawing.Point(24, 23);
            this.pLabel3.Name = "pLabel3";
            this.pLabel3.Size = new System.Drawing.Size(120, 35);
            this.pLabel3.TabIndex = 79;
            this.pLabel3.Text = "အမျိုးအစား(ခွဲ)";
            this.pLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLabel4
            // 
            this.pLabel4.BackColor = System.Drawing.Color.Red;
            this.pLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel4.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel4.Location = new System.Drawing.Point(24, 142);
            this.pLabel4.Name = "pLabel4";
            this.pLabel4.Size = new System.Drawing.Size(120, 35);
            this.pLabel4.TabIndex = 70;
            this.pLabel4.Text = "ပမာဏ";
            this.pLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLabel2
            // 
            this.pLabel2.BackColor = System.Drawing.Color.Red;
            this.pLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel2.Location = new System.Drawing.Point(24, 101);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(120, 35);
            this.pLabel2.TabIndex = 59;
            this.pLabel2.Text = "ထုပ်ပိုးခြင်းအမည်";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.Red;
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(24, 61);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(120, 35);
            this.pLabel1.TabIndex = 57;
            this.pLabel1.Text = "ကုန်ပစ္စည်းအမည်";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StockPackaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.PanelDetail);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "StockPackaging";
            this.Text = "StockPackagingType";
            this.Load += new System.EventHandler(this.StockPackaging_Load);
            this.Controls.SetChildIndex(this.PanelDetail, 0);
            this.PanelDetail.ResumeLayout(false);
            this.PanelDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelDetail;
        private POS_Control.PCombo cboItemName;
        private POS_Control.PLabel pLabel1;
        private POS_Control.PCombo cboPackagingType;
        private POS_Control.PLabel pLabel2;
        private POS_Control.PTextBox txtQty;
        private POS_Control.PLabel pLabel4;
        private POS_Control.PCombo cboSubCategory;
        private POS_Control.PLabel pLabel3;
    }
}