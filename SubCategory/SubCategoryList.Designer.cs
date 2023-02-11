namespace SubCategory
{
    partial class SubCategoryList
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
            this.pCombo1 = new POS_Control.PCombo();
            this.pLabel2 = new POS_Control.PLabel();
            this.pButton1 = new POS_Control.PButton();
            this.dgvSubcategory = new POS_Control.PGridView();
            this.pTextBox1 = new POS_Control.PTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcategory)).BeginInit();
            this.SuspendLayout();
            // 
            // pLabel1
            // 
            this.pLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel1.Location = new System.Drawing.Point(47, 84);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Size = new System.Drawing.Size(100, 30);
            this.pLabel1.TabIndex = 40;
            this.pLabel1.Text = "အမျိုးအစား";
            this.pLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pCombo1
            // 
            this.pCombo1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pCombo1.FormattingEnabled = true;
            this.pCombo1.IsDatatableOccurs = null;
            this.pCombo1.IsErrorOccurs = false;
            this.pCombo1.Location = new System.Drawing.Point(147, 84);
            this.pCombo1.MinimumSize = new System.Drawing.Size(100, 0);
            this.pCombo1.Name = "pCombo1";
            this.pCombo1.NextControl = null;
            this.pCombo1.NextControlName = null;
            this.pCombo1.Size = new System.Drawing.Size(300, 29);
            this.pCombo1.TabIndex = 41;
            // 
            // pLabel2
            // 
            this.pLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLabel2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pLabel2.Location = new System.Drawing.Point(473, 83);
            this.pLabel2.Name = "pLabel2";
            this.pLabel2.Size = new System.Drawing.Size(100, 30);
            this.pLabel2.TabIndex = 42;
            this.pLabel2.Text = "အမျိုးအစား(ခွဲ)";
            this.pLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pButton1
            // 
            this.pButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pButton1.ButtonType = Entity.ButtonType.BType.Normal;
            this.pButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pButton1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pButton1.Location = new System.Drawing.Point(899, 81);
            this.pButton1.Name = "pButton1";
            this.pButton1.Size = new System.Drawing.Size(115, 30);
            this.pButton1.TabIndex = 44;
            this.pButton1.Text = "ပြပါ";
            this.pButton1.UseVisualStyleBackColor = false;
            // 
            // dgvSubcategory
            // 
            this.dgvSubcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubcategory.Location = new System.Drawing.Point(44, 135);
            this.dgvSubcategory.Name = "dgvSubcategory";
            this.dgvSubcategory.RowTemplate.Height = 25;
            this.dgvSubcategory.Size = new System.Drawing.Size(1244, 828);
            this.dgvSubcategory.TabIndex = 45;
            // 
            // pTextBox1
            // 
            this.pTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTextBox1.DefaultKeyboard = POS_Control.PTextBox.DefKey.English;
            this.pTextBox1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pTextBox1.IsDatatableOccurs = null;
            this.pTextBox1.IsErrorOccurs = false;
            this.pTextBox1.Location = new System.Drawing.Point(573, 83);
            this.pTextBox1.MinimumSize = new System.Drawing.Size(100, 20);
            this.pTextBox1.Name = "pTextBox1";
            this.pTextBox1.NextControl = null;
            this.pTextBox1.NextControlName = null;
            this.pTextBox1.SearchType = Entity.SearchType.ScType.None;
            this.pTextBox1.Size = new System.Drawing.Size(307, 30);
            this.pTextBox1.TabIndex = 46;
            this.pTextBox1.TextBoxType = POS_Control.PTextBox.PTextBoxType.Normal;
            // 
            // SubCategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.pTextBox1);
            this.Controls.Add(this.dgvSubcategory);
            this.Controls.Add(this.pButton1);
            this.Controls.Add(this.pLabel2);
            this.Controls.Add(this.pCombo1);
            this.Controls.Add(this.pLabel1);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "SubCategoryList";
            this.Text = "SubCategoryList";
            this.Controls.SetChildIndex(this.pLabel1, 0);
            this.Controls.SetChildIndex(this.pCombo1, 0);
            this.Controls.SetChildIndex(this.pLabel2, 0);
            this.Controls.SetChildIndex(this.pButton1, 0);
            this.Controls.SetChildIndex(this.dgvSubcategory, 0);
            this.Controls.SetChildIndex(this.pTextBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private POS_Control.PLabel pLabel1;
        private POS_Control.PCombo pCombo1;
        private POS_Control.PLabel pLabel2;
        private POS_Control.PButton pButton1;
        private POS_Control.PGridView dgvSubcategory;
        private POS_Control.PTextBox pTextBox1;
    }
}