﻿namespace POS_Search
{
    partial class PackagingType_Search
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
            this.dgvPackagingType = new POS_Control.PGridView();
            this.txtPackTypeName = new POS_Control.PTextBox();
            this.pLabel1 = new POS_Control.PLabel();
            this.btnDisplay = new POS_Control.PButton();
            this.PackTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackagingType)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPackagingType
            // 
            this.dgvPackagingType.AllowUserToAddRows = false;
            this.dgvPackagingType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackagingType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackTypeCode,
            this.PackTypeName,
            this.Qty});
            this.dgvPackagingType.Location = new System.Drawing.Point(12, 105);
            this.dgvPackagingType.Name = "dgvPackagingType";
            this.dgvPackagingType.RowHeadersVisible = false;
            this.dgvPackagingType.RowTemplate.Height = 25;
            this.dgvPackagingType.Size = new System.Drawing.Size(860, 494);
            this.dgvPackagingType.TabIndex = 25;
            this.dgvPackagingType.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackagingType_CellContentDoubleClick);
            // 
            // txtPackTypeName
            // 
            this.txtPackTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackTypeName.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtPackTypeName.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPackTypeName.IsDatatableOccurs = null;
            this.txtPackTypeName.IsErrorOccurs = false;
            this.txtPackTypeName.Location = new System.Drawing.Point(115, 63);
            this.txtPackTypeName.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtPackTypeName.Name = "txtPackTypeName";
            this.txtPackTypeName.NextControl = null;
            this.txtPackTypeName.NextControlName = null;
            this.txtPackTypeName.SearchType = Entity.SearchType.ScType.None;
            this.txtPackTypeName.Size = new System.Drawing.Size(311, 30);
            this.txtPackTypeName.TabIndex = 24;
            this.txtPackTypeName.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(15, 63);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(100, 30);
            this.pLabel1.TabIndex = 23;
            this.pLabel1.Text = "အမည်";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDisplay.ButtonType = Entity.ButtonType.BType.Normal;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplay.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplay.Location = new System.Drawing.Point(488, 61);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(100, 30);
            this.btnDisplay.TabIndex = 22;
            this.btnDisplay.Text = "ပြပါ";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // PackTypeCode
            // 
            this.PackTypeCode.HeaderText = "ကုဒ်နံပါတ်";
            this.PackTypeCode.Name = "PackTypeCode";
            this.PackTypeCode.Width = 150;
            // 
            // PackTypeName
            // 
            this.PackTypeName.HeaderText = "အမည်";
            this.PackTypeName.Name = "PackTypeName";
            this.PackTypeName.Width = 580;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "ပမာဏ";
            this.Qty.Name = "Qty";
            this.Qty.Width = 125;
            // 
            // PackagingType_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.dgvPackagingType);
            this.Controls.Add(this.txtPackTypeName);
            this.Controls.Add(this.pLabel1);
            this.Controls.Add(this.btnDisplay);
            this.Name = "PackagingType_Search";
            this.Text = "PackagingType_Search";
            this.Load += new System.EventHandler(this.PackagingType_Search_Load);
            this.Controls.SetChildIndex(this.btnDisplay, 0);
            this.Controls.SetChildIndex(this.pLabel1, 0);
            this.Controls.SetChildIndex(this.txtPackTypeName, 0);
            this.Controls.SetChildIndex(this.dgvPackagingType, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackagingType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private POS_Control.PGridView dgvPackagingType;
        private POS_Control.PTextBox txtPackTypeName;
        private POS_Control.PLabel pLabel1;
        private POS_Control.PButton btnDisplay;
        private DataGridViewTextBoxColumn PackTypeCode;
        private DataGridViewTextBoxColumn PackTypeName;
        private DataGridViewTextBoxColumn Qty;
    }
}