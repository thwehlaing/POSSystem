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
            this.pLabel1 = new POS_Control.PLabel();
            this.txtSupplierName = new POS_Control.PTextBox();
            this.txtPhoneNo = new POS_Control.PTextBox();
            this.pLabel2 = new POS_Control.PLabel();
            this.txtAddress = new POS_Control.PTextBox();
            this.pLabel4 = new POS_Control.PLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdo_active = new POS_Control.PRadio();
            this.rdo_inactive = new POS_Control.PRadio();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.Red;
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(43, 95);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(100, 30);
            this.pLabel1.TabIndex = 40;
            this.pLabel1.Text = "ထောက်ပံ့သူ";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierName.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtSupplierName.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupplierName.IsDatatableOccurs = null;
            this.txtSupplierName.IsErrorOccurs = false;
            this.txtSupplierName.Location = new System.Drawing.Point(143, 95);
            this.txtSupplierName.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.NextControl = null;
            this.txtSupplierName.NextControlName = "txtPhoneNo";
            this.txtSupplierName.SearchType = Entity.SearchType.ScType.None;
            this.txtSupplierName.Size = new System.Drawing.Size(322, 30);
            this.txtSupplierName.TabIndex = 41;
            this.txtSupplierName.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNo.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtPhoneNo.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNo.IsDatatableOccurs = null;
            this.txtPhoneNo.IsErrorOccurs = false;
            this.txtPhoneNo.Location = new System.Drawing.Point(143, 140);
            this.txtPhoneNo.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.NextControl = null;
            this.txtPhoneNo.NextControlName = "txtAddress";
            this.txtPhoneNo.SearchType = Entity.SearchType.ScType.None;
            this.txtPhoneNo.Size = new System.Drawing.Size(322, 30);
            this.txtPhoneNo.TabIndex = 43;
            this.txtPhoneNo.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel2
            // 
            this.pLabel2.BackColor = System.Drawing.Color.Red;
            this.pLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel2.Location = new System.Drawing.Point(43, 140);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(100, 30);
            this.pLabel2.TabIndex = 42;
            this.pLabel2.Text = "ဖုန်းနံပါတ်";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.txtAddress.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.IsDatatableOccurs = null;
            this.txtAddress.IsErrorOccurs = false;
            this.txtAddress.Location = new System.Drawing.Point(143, 186);
            this.txtAddress.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.NextControl = null;
            this.txtAddress.NextControlName = "rdo_active";
            this.txtAddress.SearchType = Entity.SearchType.ScType.None;
            this.txtAddress.Size = new System.Drawing.Size(322, 30);
            this.txtAddress.TabIndex = 45;
            this.txtAddress.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // pLabel4
            // 
            this.pLabel4.BackColor = System.Drawing.Color.Red;
            this.pLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel4.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel4.Location = new System.Drawing.Point(43, 186);
            this.pLabel4.Name = "pLabel4";
            this.pLabel4.Size = new System.Drawing.Size(100, 30);
            this.pLabel4.TabIndex = 44;
            this.pLabel4.Text = "လိပ်စာ";
            this.pLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdo_active);
            this.panel1.Controls.Add(this.rdo_inactive);
            this.panel1.Location = new System.Drawing.Point(43, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 58);
            this.panel1.TabIndex = 46;
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
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1713, 961);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.pLabel4);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.pLabel2);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.pLabel1);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Controls.SetChildIndex(this.pLabel1, 0);
            this.Controls.SetChildIndex(this.txtSupplierName, 0);
            this.Controls.SetChildIndex(this.pLabel2, 0);
            this.Controls.SetChildIndex(this.txtPhoneNo, 0);
            this.Controls.SetChildIndex(this.pLabel4, 0);
            this.Controls.SetChildIndex(this.txtAddress, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private POS_Control.PLabel pLabel1;
        private POS_Control.PTextBox txtSupplierName;
        private POS_Control.PTextBox txtPhoneNo;
        private POS_Control.PLabel pLabel2;
        private POS_Control.PTextBox txtAddress;
        private POS_Control.PLabel pLabel4;
        private Panel panel1;
        private POS_Control.PRadio rdo_active;
        private POS_Control.PRadio rdo_inactive;
    }
}