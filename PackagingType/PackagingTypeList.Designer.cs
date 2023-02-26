namespace PackagingType
{
    partial class PackagingTypeList
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
            this.dgvPackagingType = new POS_Control.PGridView();
            this.PackTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PanelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackagingType)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDetail
            // 
            this.PanelDetail.Controls.Add(this.dgvPackagingType);
            this.PanelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PanelDetail.Location = new System.Drawing.Point(0, 57);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(1924, 939);
            this.PanelDetail.TabIndex = 40;
            // 
            // dgvPackagingType
            // 
            this.dgvPackagingType.AllowUserToAddRows = false;
            this.dgvPackagingType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackagingType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackTypeCode,
            this.PackTypeName,
            this.Qty,
            this.Action});
            this.dgvPackagingType.Location = new System.Drawing.Point(21, 24);
            this.dgvPackagingType.Name = "dgvPackagingType";
            this.dgvPackagingType.RowHeadersVisible = false;
            this.dgvPackagingType.RowTemplate.Height = 25;
            this.dgvPackagingType.Size = new System.Drawing.Size(985, 571);
            this.dgvPackagingType.TabIndex = 26;
            this.dgvPackagingType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackagingType_CellContentClick);
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
            // Action
            // 
            this.Action.HeaderText = "လုပ်ဆောင်ချက်";
            this.Action.Name = "Action";
            this.Action.Text = "ဖျက်ရန်";
            this.Action.UseColumnTextForButtonValue = true;
            this.Action.Width = 125;
            // 
            // PackagingTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.PanelDetail);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "PackagingTypeList";
            this.Text = "PackagingTypeList";
            this.Load += new System.EventHandler(this.PackagingTypeList_Load);
            this.Controls.SetChildIndex(this.PanelDetail, 0);
            this.PanelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackagingType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelDetail;
        private POS_Control.PGridView dgvPackagingType;
        private DataGridViewTextBoxColumn PackTypeCode;
        private DataGridViewTextBoxColumn PackTypeName;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewButtonColumn Action;
    }
}