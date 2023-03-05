namespace SubCategory
{
    partial class SubCategory_Edit
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
            this.cboCategory = new POS_Control.PCombo();
            this.pLabel2 = new POS_Control.PLabel();
            this.btnSearch = new POS_Control.PButton();
            this.txtSubName = new POS_Control.PTextBox();
            this.pLabel1 = new POS_Control.PLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdo_active = new POS_Control.PRadio();
            this.rdo_inactive = new POS_Control.PRadio();
            this.PanelDetail.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDetail
            // 
            this.PanelDetail.Controls.Add(this.cboCategory);
            this.PanelDetail.Controls.Add(this.pLabel2);
            this.PanelDetail.Controls.Add(this.btnSearch);
            this.PanelDetail.Controls.Add(this.txtSubName);
            this.PanelDetail.Controls.Add(this.pLabel1);
            this.PanelDetail.Controls.Add(this.panel2);
            this.PanelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetail.Location = new System.Drawing.Point(0, 57);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(1539, 722);
            this.PanelDetail.TabIndex = 40;
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.IsDatatableOccurs = null;
            this.cboCategory.IsErrorOccurs = false;
            this.cboCategory.Location = new System.Drawing.Point(131, 18);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cboCategory.MinimumSize = new System.Drawing.Size(81, 0);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.NextControl = null;
            this.cboCategory.NextControlName = "txtSubName";
            this.cboCategory.Size = new System.Drawing.Size(300, 29);
            this.cboCategory.TabIndex = 49;
            // 
            // pLabel2
            // 
            this.pLabel2.BackColor = System.Drawing.Color.Red;
            this.pLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel2.Location = new System.Drawing.Point(31, 18);
            this.pLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(100, 30);
            this.pLabel2.TabIndex = 48;
            this.pLabel2.Text = "အမျိုးအစား";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearch.ButtonType = Entity.ButtonType.BType.Normal;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(431, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSubName
            // 
            this.txtSubName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubName.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtSubName.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubName.IsDatatableOccurs = null;
            this.txtSubName.IsErrorOccurs = false;
            this.txtSubName.Location = new System.Drawing.Point(131, 55);
            this.txtSubName.MaxLength = 50;
            this.txtSubName.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.NextControl = null;
            this.txtSubName.NextControlName = "rdo_active";
            this.txtSubName.SearchType = Entity.SearchType.ScType.None;
            this.txtSubName.Size = new System.Drawing.Size(300, 30);
            this.txtSubName.TabIndex = 46;
            this.txtSubName.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.Red;
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(31, 55);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(100, 30);
            this.pLabel1.TabIndex = 45;
            this.pLabel1.Text = "အမျိုးအစား (ခွဲ)";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdo_active);
            this.panel2.Controls.Add(this.rdo_inactive);
            this.panel2.Location = new System.Drawing.Point(31, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 58);
            this.panel2.TabIndex = 44;
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
            // SubCategory_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 844);
            this.Controls.Add(this.PanelDetail);
            this.Name = "SubCategory_Edit";
            this.Text = "SubCategory_Edit";
            this.Load += new System.EventHandler(this.SubCategory_Edit_Load);
            this.Controls.SetChildIndex(this.PanelDetail, 0);
            this.PanelDetail.ResumeLayout(false);
            this.PanelDetail.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelDetail;
        private POS_Control.PButton btnSearch;
        private POS_Control.PTextBox txtSubName;
        private POS_Control.PLabel pLabel1;
        private Panel panel2;
        private POS_Control.PRadio rdo_active;
        private POS_Control.PRadio rdo_inactive;
        private POS_Control.PCombo cboCategory;
        private POS_Control.PLabel pLabel2;
    }
}