namespace Supplier
{
    partial class Supplier
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
            this.txtAddress = new POS_Control.PTextBox();
            this.pLabel4 = new POS_Control.PLabel();
            this.txtPhoneNo = new POS_Control.PTextBox();
            this.pLabel2 = new POS_Control.PLabel();
            this.txtSupplierName = new POS_Control.PTextBox();
            this.pLabel1 = new POS_Control.PLabel();
            this.PanelDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDetail
            // 
            this.PanelDetail.Controls.Add(this.panel1);
            this.PanelDetail.Controls.Add(this.txtAddress);
            this.PanelDetail.Controls.Add(this.pLabel4);
            this.PanelDetail.Controls.Add(this.txtPhoneNo);
            this.PanelDetail.Controls.Add(this.pLabel2);
            this.PanelDetail.Controls.Add(this.txtSupplierName);
            this.PanelDetail.Controls.Add(this.pLabel1);
            this.PanelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetail.Location = new System.Drawing.Point(0, 57);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(1713, 839);
            this.PanelDetail.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdo_active);
            this.panel1.Controls.Add(this.rdo_inactive);
            this.panel1.Location = new System.Drawing.Point(30, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 58);
            this.panel1.TabIndex = 53;
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
            // txtAddress
            // 
            this.txtAddress.AllowMinus = false;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.DefaultKeyboard = POS_Control.PTextBox.DefKey.Myanmar;
            this.txtAddress.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.IsDatatableOccurs = null;
            this.txtAddress.IsErrorOccurs = false;
            this.txtAddress.Location = new System.Drawing.Point(150, 121);
            this.txtAddress.MaxLength = 200;
            this.txtAddress.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.NextControl = this.rdo_active;
            this.txtAddress.NextControlName = "rdo_active";
            this.txtAddress.SearchType = Entity.SearchType.ScType.None;
            this.txtAddress.Size = new System.Drawing.Size(322, 35);
            this.txtAddress.TabIndex = 52;
            this.txtAddress.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel4
            // 
            this.pLabel4.BackColor = System.Drawing.Color.Red;
            this.pLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel4.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel4.Location = new System.Drawing.Point(30, 121);
            this.pLabel4.Name = "pLabel4";
            this.pLabel4.Size = new System.Drawing.Size(120, 35);
            this.pLabel4.TabIndex = 51;
            this.pLabel4.Text = "လိပ်စာ";
            this.pLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.AllowMinus = false;
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNo.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtPhoneNo.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNo.IsDatatableOccurs = null;
            this.txtPhoneNo.IsErrorOccurs = false;
            this.txtPhoneNo.Location = new System.Drawing.Point(150, 75);
            this.txtPhoneNo.MaxLength = 20;
            this.txtPhoneNo.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.NextControl = this.txtAddress;
            this.txtPhoneNo.NextControlName = "txtAddress";
            this.txtPhoneNo.SearchType = Entity.SearchType.ScType.None;
            this.txtPhoneNo.Size = new System.Drawing.Size(322, 35);
            this.txtPhoneNo.TabIndex = 50;
            this.txtPhoneNo.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel2
            // 
            this.pLabel2.BackColor = System.Drawing.Color.Red;
            this.pLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel2.Location = new System.Drawing.Point(30, 75);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(120, 35);
            this.pLabel2.TabIndex = 49;
            this.pLabel2.Text = "ဖုန်းနံပါတ်";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.AllowMinus = false;
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierName.DefaultKeyboard = POS_Control.PTextBox.DefKey.Myanmar;
            this.txtSupplierName.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupplierName.IsDatatableOccurs = null;
            this.txtSupplierName.IsErrorOccurs = false;
            this.txtSupplierName.Location = new System.Drawing.Point(150, 30);
            this.txtSupplierName.MaxLength = 50;
            this.txtSupplierName.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.NextControl = this.txtPhoneNo;
            this.txtSupplierName.NextControlName = "txtPhoneNo";
            this.txtSupplierName.SearchType = Entity.SearchType.ScType.None;
            this.txtSupplierName.Size = new System.Drawing.Size(322, 35);
            this.txtSupplierName.TabIndex = 48;
            this.txtSupplierName.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.Red;
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(30, 30);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(120, 35);
            this.pLabel1.TabIndex = 47;
            this.pLabel1.Text = "ထောက်ပံ့သူ";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1713, 961);
            this.Controls.Add(this.PanelDetail);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.Controls.SetChildIndex(this.PanelDetail, 0);
            this.PanelDetail.ResumeLayout(false);
            this.PanelDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelDetail;
        private Panel panel1;
        private POS_Control.PRadio rdo_active;
        private POS_Control.PRadio rdo_inactive;
        private POS_Control.PTextBox txtAddress;
        private POS_Control.PLabel pLabel4;
        private POS_Control.PTextBox txtPhoneNo;
        private POS_Control.PLabel pLabel2;
        private POS_Control.PTextBox txtSupplierName;
        private POS_Control.PLabel pLabel1;
    }
}