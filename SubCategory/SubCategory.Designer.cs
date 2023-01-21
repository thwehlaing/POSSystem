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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.pLabel4 = new POS_Control.PLabel();
            this.txtSubCategory = new POS_Control.PTextBox();
            this.pLabel5 = new POS_Control.PLabel();
            this.pLabel6 = new POS_Control.PLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboStatus);
            this.panel1.Controls.Add(this.cboCategory);
            this.panel1.Controls.Add(this.pLabel4);
            this.panel1.Controls.Add(this.txtSubCategory);
            this.panel1.Controls.Add(this.pLabel5);
            this.panel1.Controls.Add(this.pLabel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 339);
            this.panel1.TabIndex = 40;
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.ItemHeight = 21;
            this.cboStatus.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cboStatus.Location = new System.Drawing.Point(194, 173);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(128, 29);
            this.cboStatus.TabIndex = 59;
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.ItemHeight = 21;
            this.cboCategory.Location = new System.Drawing.Point(194, 62);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(254, 29);
            this.cboCategory.TabIndex = 58;
            // 
            // pLabel4
            // 
            this.pLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel4.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel4.Location = new System.Drawing.Point(96, 172);
            this.pLabel4.Name = "pLabel4";
            this.pLabel4.Size = new System.Drawing.Size(100, 30);
            this.pLabel4.TabIndex = 57;
            this.pLabel4.Text = "အခြေအနေ";
            this.pLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubCategory.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtSubCategory.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubCategory.IsDatatableOccurs = null;
            this.txtSubCategory.IsErrorOccurs = false;
            this.txtSubCategory.Location = new System.Drawing.Point(193, 117);
            this.txtSubCategory.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.Size = new System.Drawing.Size(255, 30);
            this.txtSubCategory.TabIndex = 56;
            this.txtSubCategory.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel5
            // 
            this.pLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel5.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel5.Location = new System.Drawing.Point(96, 117);
            this.pLabel5.Name = "pLabel5";
            this.pLabel5.Size = new System.Drawing.Size(100, 30);
            this.pLabel5.TabIndex = 55;
            this.pLabel5.Text = "အမျိုးအစား(ခွဲ)";
            this.pLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLabel6
            // 
            this.pLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel6.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel6.Location = new System.Drawing.Point(96, 62);
            this.pLabel6.Name = "pLabel6";
            this.pLabel6.Size = new System.Drawing.Size(100, 30);
            this.pLabel6.TabIndex = 54;
            this.pLabel6.Text = "အမျိုးအစား";
            this.pLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SubCategory";
            this.Text = "SubCategory";
            this.Load += new System.EventHandler(this.SubCategory_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox cboStatus;
        private ComboBox cboCategory;
        private POS_Control.PLabel pLabel4;
        private POS_Control.PTextBox txtSubCategory;
        private POS_Control.PLabel pLabel5;
        private POS_Control.PLabel pLabel6;
    }
}