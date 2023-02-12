namespace Supplier
{
    partial class Supplier_Edit
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
            this.rdo_active = new POS_Control.PRadio();
            this.rdo_inactive = new POS_Control.PRadio();
            this.txtAddress = new POS_Control.PTextBox();
            this.pLabel4 = new POS_Control.PLabel();
            this.txtPhoneNo = new POS_Control.PTextBox();
            this.pLabel2 = new POS_Control.PLabel();
            this.txtSupplierName = new POS_Control.PTextBox();
            this.pLabel1 = new POS_Control.PLabel();
            this.btnSearch = new POS_Control.PButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdo_active);
            this.panel1.Controls.Add(this.rdo_inactive);
            this.panel1.Location = new System.Drawing.Point(26, 229);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 93);
            this.panel1.TabIndex = 53;
            // 
            // rdo_active
            // 
            this.rdo_active.AutoSize = true;
            this.rdo_active.Checked = true;
            this.rdo_active.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdo_active.Location = new System.Drawing.Point(5, 26);
            this.rdo_active.Margin = new System.Windows.Forms.Padding(5);
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
            this.rdo_inactive.Location = new System.Drawing.Point(177, 26);
            this.rdo_inactive.Margin = new System.Windows.Forms.Padding(5);
            this.rdo_inactive.Name = "rdo_inactive";
            this.rdo_inactive.NextControl = null;
            this.rdo_inactive.NextControlName = "BtnF2";
            this.rdo_inactive.Size = new System.Drawing.Size(78, 25);
            this.rdo_inactive.TabIndex = 3;
            this.rdo_inactive.Text = "အသုံးမပြု";
            this.rdo_inactive.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtAddress.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.IsDatatableOccurs = null;
            this.txtAddress.IsErrorOccurs = false;
            this.txtAddress.Location = new System.Drawing.Point(123, 179);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddress.MinimumSize = new System.Drawing.Size(170, 20);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.NextControl = null;
            this.txtAddress.NextControlName = null;
            this.txtAddress.SearchType = Entity.SearchType.ScType.None;
            this.txtAddress.Size = new System.Drawing.Size(322, 30);
            this.txtAddress.TabIndex = 52;
            this.txtAddress.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel4
            // 
            this.pLabel4.BackColor = System.Drawing.Color.Red;
            this.pLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel4.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel4.Location = new System.Drawing.Point(26, 179);
            this.pLabel4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pLabel4.Name = "pLabel4";
            this.pLabel4.Size = new System.Drawing.Size(100, 30);
            this.pLabel4.TabIndex = 51;
            this.pLabel4.Text = "လိပ်စာ";
            this.pLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNo.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtPhoneNo.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNo.IsDatatableOccurs = null;
            this.txtPhoneNo.IsErrorOccurs = false;
            this.txtPhoneNo.Location = new System.Drawing.Point(123, 133);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhoneNo.MinimumSize = new System.Drawing.Size(170, 20);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.NextControl = null;
            this.txtPhoneNo.NextControlName = null;
            this.txtPhoneNo.SearchType = Entity.SearchType.ScType.None;
            this.txtPhoneNo.Size = new System.Drawing.Size(322, 30);
            this.txtPhoneNo.TabIndex = 50;
            this.txtPhoneNo.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel2
            // 
            this.pLabel2.BackColor = System.Drawing.Color.Red;
            this.pLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel2.Location = new System.Drawing.Point(26, 133);
            this.pLabel2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(100, 30);
            this.pLabel2.TabIndex = 49;
            this.pLabel2.Text = "ဖုန်းနံပါတ်";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierName.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtSupplierName.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupplierName.IsDatatableOccurs = null;
            this.txtSupplierName.IsErrorOccurs = false;
            this.txtSupplierName.Location = new System.Drawing.Point(123, 84);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(5);
            this.txtSupplierName.MinimumSize = new System.Drawing.Size(170, 20);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.NextControl = null;
            this.txtSupplierName.NextControlName = null;
            this.txtSupplierName.SearchType = Entity.SearchType.ScType.None;
            this.txtSupplierName.Size = new System.Drawing.Size(322, 30);
            this.txtSupplierName.TabIndex = 48;
            this.txtSupplierName.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.Red;
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(26, 84);
            this.pLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(100, 30);
            this.pLabel1.TabIndex = 47;
            this.pLabel1.Text = "ထောက်ပံ့သူ";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearch.ButtonType = Entity.ButtonType.BType.Normal;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(444, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Supplier_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.pLabel4);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.pLabel2);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.pLabel1);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Supplier_Edit";
            this.Text = "Supplier_Edit";
            this.Load += new System.EventHandler(this.Supplier_Edit_Load);
            this.Controls.SetChildIndex(this.pLabel1, 0);
            this.Controls.SetChildIndex(this.txtSupplierName, 0);
            this.Controls.SetChildIndex(this.pLabel2, 0);
            this.Controls.SetChildIndex(this.txtPhoneNo, 0);
            this.Controls.SetChildIndex(this.pLabel4, 0);
            this.Controls.SetChildIndex(this.txtAddress, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private POS_Control.PRadio rdo_active;
        private POS_Control.PRadio rdo_inactive;
        private POS_Control.PTextBox txtAddress;
        private POS_Control.PLabel pLabel4;
        private POS_Control.PTextBox txtPhoneNo;
        private POS_Control.PLabel pLabel2;
        private POS_Control.PTextBox txtSupplierName;
        private POS_Control.PLabel pLabel1;
        private POS_Control.PButton btnSearch;
    }
}