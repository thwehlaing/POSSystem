namespace POS_Search
{
    partial class Search_Base
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SBtn1 = new POS_Control.PButton();
            this.SBtn2 = new POS_Control.PButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.84783F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.15218F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.SBtn2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SBtn1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 408);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(851, 44);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SBtn1
            // 
            this.SBtn1.BackColor = System.Drawing.Color.White;
            this.SBtn1.ButtonType = Entity.ButtonType.BType.Normal;
            this.SBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SBtn1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SBtn1.Location = new System.Drawing.Point(3, 3);
            this.SBtn1.Name = "SBtn1";
            this.SBtn1.Size = new System.Drawing.Size(117, 38);
            this.SBtn1.TabIndex = 0;
            this.SBtn1.Text = "ပိတ်မည်";
            this.SBtn1.UseVisualStyleBackColor = false;
            // 
            // SBtn2
            // 
            this.SBtn2.BackColor = System.Drawing.Color.White;
            this.SBtn2.ButtonType = Entity.ButtonType.BType.Normal;
            this.SBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SBtn2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SBtn2.Location = new System.Drawing.Point(733, 3);
            this.SBtn2.Name = "SBtn2";
            this.SBtn2.Size = new System.Drawing.Size(115, 38);
            this.SBtn2.TabIndex = 1;
            this.SBtn2.Text = "ယူမည်";
            this.SBtn2.UseVisualStyleBackColor = false;
            // 
            // Search_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 452);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Search_Base";
            this.Text = "Search_Base";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private POS_Control.PButton SBtn1;
        private POS_Control.PButton SBtn2;
    }
}