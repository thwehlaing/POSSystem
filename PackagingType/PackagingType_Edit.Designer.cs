namespace PackagingType
{
    partial class PackagingType_Edit
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdo_active = new POS_Control.PRadio();
            this.rdo_inactive = new POS_Control.PRadio();
            this.txtQty = new POS_Control.PTextBox();
            this.lblQty = new POS_Control.PLabel();
            this.txtPackTypeName = new POS_Control.PTextBox();
            this.pLabel2 = new POS_Control.PLabel();
            this.btnSearch = new POS_Control.PButton();
            this.PanelDetail.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDetail
            // 
            this.PanelDetail.Controls.Add(this.btnSearch);
            this.PanelDetail.Controls.Add(this.panel2);
            this.PanelDetail.Controls.Add(this.txtQty);
            this.PanelDetail.Controls.Add(this.lblQty);
            this.PanelDetail.Controls.Add(this.txtPackTypeName);
            this.PanelDetail.Controls.Add(this.pLabel2);
            this.PanelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetail.Location = new System.Drawing.Point(0, 57);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(1713, 839);
            this.PanelDetail.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdo_active);
            this.panel2.Controls.Add(this.rdo_inactive);
            this.panel2.Location = new System.Drawing.Point(27, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 58);
            this.panel2.TabIndex = 75;
            // 
            // rdo_active
            // 
            this.rdo_active.AutoSize = true;
            this.rdo_active.Checked = true;
            this.rdo_active.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdo_active.Location = new System.Drawing.Point(3, 16);
            this.rdo_active.Name = "rdo_active";
            this.rdo_active.NextControl = null;
            this.rdo_active.NextControlName = "BtnF2";
            this.rdo_active.Size = new System.Drawing.Size(70, 25);
            this.rdo_active.TabIndex = 2;
            this.rdo_active.TabStop = true;
            this.rdo_active.Text = "အသုံးပြု";
            this.rdo_active.UseVisualStyleBackColor = true;
            // 
            // rdo_inactive
            // 
            this.rdo_inactive.AutoSize = true;
            this.rdo_inactive.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdo_inactive.Location = new System.Drawing.Point(103, 16);
            this.rdo_inactive.Name = "rdo_inactive";
            this.rdo_inactive.NextControl = null;
            this.rdo_inactive.NextControlName = "BtnF2";
            this.rdo_inactive.Size = new System.Drawing.Size(78, 25);
            this.rdo_inactive.TabIndex = 3;
            this.rdo_inactive.Text = "အသုံးမပြု";
            this.rdo_inactive.UseVisualStyleBackColor = true;
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtQty.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQty.IsDatatableOccurs = null;
            this.txtQty.IsErrorOccurs = false;
            this.txtQty.Location = new System.Drawing.Point(127, 68);
            this.txtQty.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtQty.Name = "txtQty";
            this.txtQty.NextControl = null;
            this.txtQty.NextControlName = "rdo_active";
            this.txtQty.SearchType = Entity.SearchType.ScType.None;
            this.txtQty.Size = new System.Drawing.Size(187, 30);
            this.txtQty.TabIndex = 74;
            this.txtQty.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // lblQty
            // 
            this.lblQty.BackColor = System.Drawing.Color.Red;
            this.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQty.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQty.Location = new System.Drawing.Point(27, 68);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(100, 30);
            this.lblQty.TabIndex = 73;
            this.lblQty.Text = "ပမာဏ";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPackTypeName
            // 
            this.txtPackTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackTypeName.DefaultKeyboard = POS_Control.PTextBox.DefKey.Myanmar;
            this.txtPackTypeName.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPackTypeName.IsDatatableOccurs = null;
            this.txtPackTypeName.IsErrorOccurs = false;
            this.txtPackTypeName.Location = new System.Drawing.Point(127, 25);
            this.txtPackTypeName.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtPackTypeName.Name = "txtPackTypeName";
            this.txtPackTypeName.NextControl = null;
            this.txtPackTypeName.NextControlName = "txtQty";
            this.txtPackTypeName.SearchType = Entity.SearchType.ScType.None;
            this.txtPackTypeName.Size = new System.Drawing.Size(322, 30);
            this.txtPackTypeName.TabIndex = 72;
            this.txtPackTypeName.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel2
            // 
            this.pLabel2.BackColor = System.Drawing.Color.Red;
            this.pLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel2.Location = new System.Drawing.Point(27, 25);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(100, 30);
            this.pLabel2.TabIndex = 71;
            this.pLabel2.Text = "အမည်";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearch.ButtonType = Entity.ButtonType.BType.Normal;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(449, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 86;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // PackagingType_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1713, 961);
            this.Controls.Add(this.PanelDetail);
            this.Name = "PackagingType_Edit";
            this.Text = "PackagingType_Edit";
            this.Load += new System.EventHandler(this.PackagingType_Edit_Load);
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
        private POS_Control.PTextBox txtQty;
        private POS_Control.PLabel lblQty;
        private POS_Control.PTextBox txtPackTypeName;
        private POS_Control.PLabel pLabel2;
        private POS_Control.PButton btnSearch;
    }
}