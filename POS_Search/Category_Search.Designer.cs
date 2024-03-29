﻿namespace POS_Search
{
    partial class Category_Search
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
            this.dgvCategory = new POS_Control.PGridView();
            this.CatCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDisplay = new POS_Control.PButton();
            this.pLabel1 = new POS_Control.PLabel();
            this.txtCategoryName = new POS_Control.PTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CatCD,
            this.CatName});
            this.dgvCategory.Location = new System.Drawing.Point(12, 104);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.RowTemplate.Height = 25;
            this.dgvCategory.Size = new System.Drawing.Size(860, 494);
            this.dgvCategory.TabIndex = 21;
            this.dgvCategory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategory_CellMouseDoubleClick);
            // 
            // CatCD
            // 
            this.CatCD.HeaderText = "ကုဒ်နံပါတ်";
            this.CatCD.Name = "CatCD";
            this.CatCD.ReadOnly = true;
            this.CatCD.Visible = false;
            this.CatCD.Width = 200;
            // 
            // CatName
            // 
            this.CatName.HeaderText = "အမည်";
            this.CatName.Name = "CatName";
            this.CatName.ReadOnly = true;
            this.CatName.Width = 850;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.White;
            this.btnDisplay.ButtonType = Entity.ButtonType.BType.Normal;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplay.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplay.Location = new System.Drawing.Point(488, 60);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(100, 37);
            this.btnDisplay.TabIndex = 18;
            this.btnDisplay.Text = "ပြပါ";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(15, 62);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(100, 35);
            this.pLabel1.TabIndex = 19;
            this.pLabel1.Text = "အမည်";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.AllowMinus = false;
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryName.DefaultKeyboard = POS_Control.PTextBox.DefKey.Myanmar;
            this.txtCategoryName.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCategoryName.IsDatatableOccurs = null;
            this.txtCategoryName.IsErrorOccurs = false;
            this.txtCategoryName.Location = new System.Drawing.Point(115, 62);
            this.txtCategoryName.MinimumSize = new System.Drawing.Size(100, 30);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.NextControl = this.btnDisplay;
            this.txtCategoryName.NextControlName = "btnDisplay";
            this.txtCategoryName.SearchType = Entity.SearchType.ScType.None;
            this.txtCategoryName.Size = new System.Drawing.Size(319, 35);
            this.txtCategoryName.TabIndex = 22;
            this.txtCategoryName.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // Category_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.pLabel1);
            this.Controls.Add(this.btnDisplay);
            this.Name = "Category_Search";
            this.Text = "Category_Search";
            this.Load += new System.EventHandler(this.Category_Search_Load);
            this.Controls.SetChildIndex(this.btnDisplay, 0);
            this.Controls.SetChildIndex(this.pLabel1, 0);
            this.Controls.SetChildIndex(this.dgvCategory, 0);
            this.Controls.SetChildIndex(this.txtCategoryName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private POS_Control.PGridView dgvCategory;
        private POS_Control.PLabel pLabel1;
        private POS_Control.PButton btnDisplay;
        private DataGridViewTextBoxColumn CatCD;
        private DataGridViewTextBoxColumn CatName;
        private POS_Control.PTextBox txtCategoryName;
    }
}