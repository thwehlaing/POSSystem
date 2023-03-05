namespace SubCategory
{
    partial class SubCategory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdo_active = new POS_Control.PRadio();
            this.rdo_inactive = new POS_Control.PRadio();
            this.txtSubCategory = new POS_Control.PTextBox();
            this.pLabel2 = new POS_Control.PLabel();
            this.cboCategory = new POS_Control.PCombo();
            this.pLabel1 = new POS_Control.PLabel();
            this.PanelDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDetail
            // 
            this.PanelDetail.Controls.Add(this.panel1);
            this.PanelDetail.Controls.Add(this.txtSubCategory);
            this.PanelDetail.Controls.Add(this.pLabel2);
            this.PanelDetail.Controls.Add(this.cboCategory);
            this.PanelDetail.Controls.Add(this.pLabel1);
            this.PanelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetail.Location = new System.Drawing.Point(0, 57);
            this.PanelDetail.Margin = new System.Windows.Forms.Padding(2);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(1713, 839);
            this.PanelDetail.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdo_active);
            this.panel1.Controls.Add(this.rdo_inactive);
            this.panel1.Location = new System.Drawing.Point(31, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 58);
            this.panel1.TabIndex = 3;
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
            // txtSubCategory
            // 
            this.txtSubCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubCategory.DefaultKeyboard = POS_Control.PTextBox.DefKey.Myanmar;
            this.txtSubCategory.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubCategory.IsDatatableOccurs = null;
            this.txtSubCategory.IsErrorOccurs = false;
            this.txtSubCategory.Location = new System.Drawing.Point(131, 60);
            this.txtSubCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubCategory.MaxLength = 50;
            this.txtSubCategory.MinimumSize = new System.Drawing.Size(80, 20);
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.NextControl = null;
            this.txtSubCategory.NextControlName = "rdo_active";
            this.txtSubCategory.SearchType = Entity.SearchType.ScType.None;
            this.txtSubCategory.Size = new System.Drawing.Size(344, 30);
            this.txtSubCategory.TabIndex = 2;
            this.txtSubCategory.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel2
            // 
            this.pLabel2.BackColor = System.Drawing.Color.Red;
            this.pLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel2.Location = new System.Drawing.Point(31, 60);
            this.pLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(100, 30);
            this.pLabel2.TabIndex = 2;
            this.pLabel2.Text = "အမျိုးအစား(ခွဲ)";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.IsDatatableOccurs = null;
            this.cboCategory.IsErrorOccurs = false;
            this.cboCategory.Location = new System.Drawing.Point(131, 23);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cboCategory.MinimumSize = new System.Drawing.Size(81, 0);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.NextControl = null;
            this.cboCategory.NextControlName = "txtSubCategory";
            this.cboCategory.Size = new System.Drawing.Size(344, 29);
            this.cboCategory.TabIndex = 1;
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.Red;
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(31, 23);
            this.pLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(100, 30);
            this.pLabel1.TabIndex = 0;
            this.pLabel1.Text = "အမျိုးအစား";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1713, 961);
            this.Controls.Add(this.PanelDetail);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SubCategory";
            this.Text = "Subcategory";
            this.Load += new System.EventHandler(this.SubCategory_Load);
            this.Controls.SetChildIndex(this.PanelDetail, 0);
            this.PanelDetail.ResumeLayout(false);
            this.PanelDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelDetail;
        private POS_Control.PLabel pLabel1;
        private POS_Control.PCombo cboCategory;
        private POS_Control.PLabel pLabel2;
        private POS_Control.PTextBox txtSubCategory;
        private Panel panel1;
        private POS_Control.PRadio rdo_active;
        private POS_Control.PRadio rdo_inactive;
    }
}