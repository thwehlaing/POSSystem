﻿namespace StockItem
{
    partial class StockItem_Edit
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
            this.btnSearch = new POS_Control.PButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdo_active = new POS_Control.PRadio();
            this.rdo_inactive = new POS_Control.PRadio();
            this.txtReorderQty = new POS_Control.PTextBox();
            this.pLabel7 = new POS_Control.PLabel();
            this.txtBarCode = new POS_Control.PTextBox();
            this.pLabel6 = new POS_Control.PLabel();
            this.txtPrice = new POS_Control.PTextBox();
            this.pLabel5 = new POS_Control.PLabel();
            this.txtQty = new POS_Control.PTextBox();
            this.pLabel4 = new POS_Control.PLabel();
            this.cboUOM = new POS_Control.PCombo();
            this.pLabel3 = new POS_Control.PLabel();
            this.txtStockName = new POS_Control.PTextBox();
            this.pLabel2 = new POS_Control.PLabel();
            this.cboSubCategory = new POS_Control.PCombo();
            this.pLabel1 = new POS_Control.PLabel();
            this.PanelDetail.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDetail
            // 
            this.PanelDetail.Controls.Add(this.btnSearch);
            this.PanelDetail.Controls.Add(this.panel2);
            this.PanelDetail.Controls.Add(this.txtReorderQty);
            this.PanelDetail.Controls.Add(this.pLabel7);
            this.PanelDetail.Controls.Add(this.txtBarCode);
            this.PanelDetail.Controls.Add(this.pLabel6);
            this.PanelDetail.Controls.Add(this.txtPrice);
            this.PanelDetail.Controls.Add(this.pLabel5);
            this.PanelDetail.Controls.Add(this.txtQty);
            this.PanelDetail.Controls.Add(this.pLabel4);
            this.PanelDetail.Controls.Add(this.cboUOM);
            this.PanelDetail.Controls.Add(this.pLabel3);
            this.PanelDetail.Controls.Add(this.txtStockName);
            this.PanelDetail.Controls.Add(this.pLabel2);
            this.PanelDetail.Controls.Add(this.cboSubCategory);
            this.PanelDetail.Controls.Add(this.pLabel1);
            this.PanelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetail.Location = new System.Drawing.Point(0, 57);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(1924, 939);
            this.PanelDetail.TabIndex = 40;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearch.ButtonType = Entity.ButtonType.BType.Normal;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(467, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 35);
            this.btnSearch.TabIndex = 85;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdo_active);
            this.panel2.Controls.Add(this.rdo_inactive);
            this.panel2.Location = new System.Drawing.Point(25, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 58);
            this.panel2.TabIndex = 84;
            // 
            // rdo_active
            // 
            this.rdo_active.AutoSize = true;
            this.rdo_active.Checked = true;
            this.rdo_active.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdo_active.Location = new System.Drawing.Point(3, 16);
            this.rdo_active.Name = "rdo_active";
            this.rdo_active.NextControl = null;
            this.rdo_active.NextControlName = "BtnF2";
            this.rdo_active.Size = new System.Drawing.Size(79, 31);
            this.rdo_active.TabIndex = 2;
            this.rdo_active.TabStop = true;
            this.rdo_active.Text = "အသုံးပြု";
            this.rdo_active.UseVisualStyleBackColor = true;
            // 
            // rdo_inactive
            // 
            this.rdo_inactive.AutoSize = true;
            this.rdo_inactive.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdo_inactive.Location = new System.Drawing.Point(103, 16);
            this.rdo_inactive.Name = "rdo_inactive";
            this.rdo_inactive.NextControl = null;
            this.rdo_inactive.NextControlName = "BtnF2";
            this.rdo_inactive.Size = new System.Drawing.Size(88, 31);
            this.rdo_inactive.TabIndex = 3;
            this.rdo_inactive.Text = "အသုံးမပြု";
            this.rdo_inactive.UseVisualStyleBackColor = true;
            // 
            // txtReorderQty
            // 
            this.txtReorderQty.AllowMinus = false;
            this.txtReorderQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReorderQty.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtReorderQty.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReorderQty.IsDatatableOccurs = null;
            this.txtReorderQty.IsErrorOccurs = false;
            this.txtReorderQty.Location = new System.Drawing.Point(145, 268);
            this.txtReorderQty.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtReorderQty.Name = "txtReorderQty";
            this.txtReorderQty.NextControl = this.rdo_active;
            this.txtReorderQty.NextControlName = "rdo_active";
            this.txtReorderQty.SearchType = Entity.SearchType.ScType.None;
            this.txtReorderQty.Size = new System.Drawing.Size(187, 35);
            this.txtReorderQty.TabIndex = 83;
            this.txtReorderQty.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel7
            // 
            this.pLabel7.BackColor = System.Drawing.Color.Red;
            this.pLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel7.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel7.Location = new System.Drawing.Point(25, 268);
            this.pLabel7.Name = "pLabel7";
            this.pLabel7.Size = new System.Drawing.Size(120, 35);
            this.pLabel7.TabIndex = 82;
            this.pLabel7.Text = "အနဲဆုံးလက်ကျန်";
            this.pLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBarCode
            // 
            this.txtBarCode.AllowMinus = false;
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarCode.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtBarCode.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBarCode.IsDatatableOccurs = null;
            this.txtBarCode.IsErrorOccurs = false;
            this.txtBarCode.Location = new System.Drawing.Point(145, 224);
            this.txtBarCode.MaxLength = 50;
            this.txtBarCode.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.NextControl = this.txtReorderQty;
            this.txtBarCode.NextControlName = "txtReorderQty";
            this.txtBarCode.SearchType = Entity.SearchType.ScType.None;
            this.txtBarCode.Size = new System.Drawing.Size(187, 35);
            this.txtBarCode.TabIndex = 81;
            this.txtBarCode.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel6
            // 
            this.pLabel6.BackColor = System.Drawing.Color.Red;
            this.pLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel6.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel6.Location = new System.Drawing.Point(25, 224);
            this.pLabel6.Name = "pLabel6";
            this.pLabel6.Size = new System.Drawing.Size(120, 35);
            this.pLabel6.TabIndex = 80;
            this.pLabel6.Text = "ဘားကုဒ်";
            this.pLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.AllowMinus = false;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtPrice.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.IsDatatableOccurs = null;
            this.txtPrice.IsErrorOccurs = false;
            this.txtPrice.Location = new System.Drawing.Point(145, 182);
            this.txtPrice.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.NextControl = this.txtBarCode;
            this.txtPrice.NextControlName = "txtBarCode";
            this.txtPrice.SearchType = Entity.SearchType.ScType.None;
            this.txtPrice.Size = new System.Drawing.Size(187, 35);
            this.txtPrice.TabIndex = 79;
            this.txtPrice.TextBoxType = POS_Control.PTextBox.PTextBoxType.Price;
            // 
            // pLabel5
            // 
            this.pLabel5.BackColor = System.Drawing.Color.Red;
            this.pLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel5.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel5.Location = new System.Drawing.Point(25, 182);
            this.pLabel5.Name = "pLabel5";
            this.pLabel5.Size = new System.Drawing.Size(120, 35);
            this.pLabel5.TabIndex = 78;
            this.pLabel5.Text = "စျေးနှုန်း";
            this.pLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQty
            // 
            this.txtQty.AllowMinus = false;
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtQty.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQty.IsDatatableOccurs = null;
            this.txtQty.IsErrorOccurs = false;
            this.txtQty.Location = new System.Drawing.Point(145, 142);
            this.txtQty.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtQty.Name = "txtQty";
            this.txtQty.NextControl = this.txtPrice;
            this.txtQty.NextControlName = "txtPrice";
            this.txtQty.SearchType = Entity.SearchType.ScType.None;
            this.txtQty.Size = new System.Drawing.Size(187, 35);
            this.txtQty.TabIndex = 77;
            this.txtQty.TextBoxType = POS_Control.PTextBox.PTextBoxType.Number;
            // 
            // pLabel4
            // 
            this.pLabel4.BackColor = System.Drawing.Color.Red;
            this.pLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel4.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel4.Location = new System.Drawing.Point(25, 142);
            this.pLabel4.Name = "pLabel4";
            this.pLabel4.Size = new System.Drawing.Size(120, 35);
            this.pLabel4.TabIndex = 76;
            this.pLabel4.Text = "ပမာဏ";
            this.pLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboUOM
            // 
            this.cboUOM.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboUOM.FormattingEnabled = true;
            this.cboUOM.IsDatatableOccurs = null;
            this.cboUOM.IsErrorOccurs = false;
            this.cboUOM.Location = new System.Drawing.Point(145, 103);
            this.cboUOM.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboUOM.Name = "cboUOM";
            this.cboUOM.NextControl = this.txtQty;
            this.cboUOM.NextControlName = "txtQty";
            this.cboUOM.Size = new System.Drawing.Size(187, 35);
            this.cboUOM.TabIndex = 75;
            // 
            // pLabel3
            // 
            this.pLabel3.BackColor = System.Drawing.Color.Red;
            this.pLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel3.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel3.Location = new System.Drawing.Point(25, 103);
            this.pLabel3.Name = "pLabel3";
            this.pLabel3.Size = new System.Drawing.Size(120, 35);
            this.pLabel3.TabIndex = 74;
            this.pLabel3.Text = "ယူနစ်";
            this.pLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStockName
            // 
            this.txtStockName.AllowMinus = false;
            this.txtStockName.BackColor = System.Drawing.Color.White;
            this.txtStockName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockName.DefaultKeyboard = POS_Control.PTextBox.DefKey.Myanmar;
            this.txtStockName.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStockName.IsDatatableOccurs = null;
            this.txtStockName.IsErrorOccurs = false;
            this.txtStockName.Location = new System.Drawing.Point(145, 64);
            this.txtStockName.MaxLength = 100;
            this.txtStockName.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.NextControl = this.cboUOM;
            this.txtStockName.NextControlName = "cboUOM";
            this.txtStockName.SearchType = Entity.SearchType.ScType.None;
            this.txtStockName.Size = new System.Drawing.Size(322, 35);
            this.txtStockName.TabIndex = 73;
            this.txtStockName.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel2
            // 
            this.pLabel2.BackColor = System.Drawing.Color.Red;
            this.pLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel2.Location = new System.Drawing.Point(25, 64);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(120, 35);
            this.pLabel2.TabIndex = 72;
            this.pLabel2.Text = "အမည်";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboSubCategory
            // 
            this.cboSubCategory.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSubCategory.FormattingEnabled = true;
            this.cboSubCategory.IsDatatableOccurs = null;
            this.cboSubCategory.IsErrorOccurs = false;
            this.cboSubCategory.Location = new System.Drawing.Point(145, 24);
            this.cboSubCategory.MinimumSize = new System.Drawing.Size(100, 0);
            this.cboSubCategory.Name = "cboSubCategory";
            this.cboSubCategory.NextControl = this.txtStockName;
            this.cboSubCategory.NextControlName = "txtStockName";
            this.cboSubCategory.Size = new System.Drawing.Size(397, 35);
            this.cboSubCategory.TabIndex = 71;
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.Red;
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(25, 24);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(120, 35);
            this.pLabel1.TabIndex = 70;
            this.pLabel1.Text = "အမျိုးအစား(ခွဲ)";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StockItem_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.PanelDetail);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "StockItem_Edit";
            this.Text = "StockItem_Edit";
            this.Load += new System.EventHandler(this.StockItem_Edit_Load);
            this.Controls.SetChildIndex(this.PanelDetail, 0);
            this.PanelDetail.ResumeLayout(false);
            this.PanelDetail.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelDetail;
        private Panel panel2;
        private POS_Control.PRadio rdo_active;
        private POS_Control.PRadio rdo_inactive;
        private POS_Control.PTextBox txtReorderQty;
        private POS_Control.PLabel pLabel7;
        private POS_Control.PTextBox txtBarCode;
        private POS_Control.PLabel pLabel6;
        private POS_Control.PTextBox txtPrice;
        private POS_Control.PLabel pLabel5;
        private POS_Control.PTextBox txtQty;
        private POS_Control.PLabel pLabel4;
        private POS_Control.PCombo cboUOM;
        private POS_Control.PLabel pLabel3;
        private POS_Control.PTextBox txtStockName;
        private POS_Control.PLabel pLabel2;
        private POS_Control.PCombo cboSubCategory;
        private POS_Control.PLabel pLabel1;
        private POS_Control.PButton btnSearch;
    }
}