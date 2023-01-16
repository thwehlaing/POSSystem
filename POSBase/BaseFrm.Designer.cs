namespace POSBase
{
    partial class BaseFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tspLoginUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tspCurrentDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tspLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pButton13 = new POS_Control.PButton();
            this.pButton1 = new POS_Control.PButton();
            this.pButton2 = new POS_Control.PButton();
            this.pButton3 = new POS_Control.PButton();
            this.pButton4 = new POS_Control.PButton();
            this.pButton5 = new POS_Control.PButton();
            this.pButton6 = new POS_Control.PButton();
            this.pButton7 = new POS_Control.PButton();
            this.pButton8 = new POS_Control.PButton();
            this.pButton9 = new POS_Control.PButton();
            this.pButton10 = new POS_Control.PButton();
            this.pButton11 = new POS_Control.PButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.80007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.19993F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Navy;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 57);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspLoginUser,
            this.tspCurrentDate,
            this.tspLogOut});
            this.menuStrip1.Location = new System.Drawing.Point(956, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(412, 53);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tspLoginUser
            // 
            this.tspLoginUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tspLoginUser.ForeColor = System.Drawing.Color.Black;
            this.tspLoginUser.Image = global::POSBase.Properties.Resources.icons8_user_16;
            this.tspLoginUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspLoginUser.Name = "tspLoginUser";
            this.tspLoginUser.Size = new System.Drawing.Size(144, 47);
            this.tspLoginUser.Text = "Welcome Admin";
            // 
            // tspCurrentDate
            // 
            this.tspCurrentDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tspCurrentDate.ForeColor = System.Drawing.Color.Black;
            this.tspCurrentDate.Image = global::POSBase.Properties.Resources.icons8_calendar_16;
            this.tspCurrentDate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspCurrentDate.Name = "tspCurrentDate";
            this.tspCurrentDate.Size = new System.Drawing.Size(116, 47);
            this.tspCurrentDate.Text = "MenuItem2";
            // 
            // tspLogOut
            // 
            this.tspLogOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tspLogOut.ForeColor = System.Drawing.Color.Black;
            this.tspLogOut.Image = global::POSBase.Properties.Resources.icons8_login_16;
            this.tspLogOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspLogOut.Name = "tspLogOut";
            this.tspLogOut.Size = new System.Drawing.Size(84, 47);
            this.tspLogOut.Text = "Logout";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "444";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pButton13
            // 
            this.pButton13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pButton13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pButton13.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pButton13.Location = new System.Drawing.Point(1, 659);
            this.pButton13.Name = "pButton13";
            this.pButton13.Size = new System.Drawing.Size(113, 44);
            this.pButton13.TabIndex = 7;
            this.pButton13.Text = "(F1)";
            this.pButton13.UseVisualStyleBackColor = false;
            // 
            // pButton1
            // 
            this.pButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pButton1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pButton1.Location = new System.Drawing.Point(115, 659);
            this.pButton1.Name = "pButton1";
            this.pButton1.Size = new System.Drawing.Size(113, 44);
            this.pButton1.TabIndex = 8;
            this.pButton1.Text = "(F2)";
            this.pButton1.UseVisualStyleBackColor = false;
            // 
            // pButton2
            // 
            this.pButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pButton2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pButton2.Location = new System.Drawing.Point(343, 659);
            this.pButton2.Name = "pButton2";
            this.pButton2.Size = new System.Drawing.Size(113, 44);
            this.pButton2.TabIndex = 10;
            this.pButton2.Text = "(F4)";
            this.pButton2.UseVisualStyleBackColor = false;
            // 
            // pButton3
            // 
            this.pButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pButton3.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pButton3.Location = new System.Drawing.Point(229, 659);
            this.pButton3.Name = "pButton3";
            this.pButton3.Size = new System.Drawing.Size(113, 44);
            this.pButton3.TabIndex = 9;
            this.pButton3.Text = "(F3)";
            this.pButton3.UseVisualStyleBackColor = false;
            // 
            // pButton4
            // 
            this.pButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pButton4.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pButton4.Location = new System.Drawing.Point(799, 659);
            this.pButton4.Name = "pButton4";
            this.pButton4.Size = new System.Drawing.Size(113, 44);
            this.pButton4.TabIndex = 14;
            this.pButton4.Text = "(F8)";
            this.pButton4.UseVisualStyleBackColor = false;
            // 
            // pButton5
            // 
            this.pButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pButton5.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pButton5.Location = new System.Drawing.Point(685, 659);
            this.pButton5.Name = "pButton5";
            this.pButton5.Size = new System.Drawing.Size(113, 44);
            this.pButton5.TabIndex = 13;
            this.pButton5.Text = "(F7)";
            this.pButton5.UseVisualStyleBackColor = false;
            // 
            // pButton6
            // 
            this.pButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pButton6.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pButton6.Location = new System.Drawing.Point(571, 659);
            this.pButton6.Name = "pButton6";
            this.pButton6.Size = new System.Drawing.Size(113, 44);
            this.pButton6.TabIndex = 12;
            this.pButton6.Text = "(F6)";
            this.pButton6.UseVisualStyleBackColor = false;
            // 
            // pButton7
            // 
            this.pButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pButton7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pButton7.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pButton7.Location = new System.Drawing.Point(457, 659);
            this.pButton7.Name = "pButton7";
            this.pButton7.Size = new System.Drawing.Size(113, 44);
            this.pButton7.TabIndex = 11;
            this.pButton7.Text = "(F5)";
            this.pButton7.UseVisualStyleBackColor = false;
            // 
            // pButton8
            // 
            this.pButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pButton8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pButton8.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pButton8.Location = new System.Drawing.Point(1255, 659);
            this.pButton8.Name = "pButton8";
            this.pButton8.Size = new System.Drawing.Size(113, 44);
            this.pButton8.TabIndex = 20;
            this.pButton8.Text = "(F12)";
            this.pButton8.UseVisualStyleBackColor = false;
            // 
            // pButton9
            // 
            this.pButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pButton9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pButton9.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pButton9.Location = new System.Drawing.Point(1141, 659);
            this.pButton9.Name = "pButton9";
            this.pButton9.Size = new System.Drawing.Size(113, 44);
            this.pButton9.TabIndex = 19;
            this.pButton9.Text = "(F11)";
            this.pButton9.UseVisualStyleBackColor = false;
            // 
            // pButton10
            // 
            this.pButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pButton10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pButton10.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pButton10.Location = new System.Drawing.Point(913, 659);
            this.pButton10.Name = "pButton10";
            this.pButton10.Size = new System.Drawing.Size(113, 44);
            this.pButton10.TabIndex = 18;
            this.pButton10.Text = "(F9)";
            this.pButton10.UseVisualStyleBackColor = false;
            // 
            // pButton11
            // 
            this.pButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pButton11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pButton11.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pButton11.Location = new System.Drawing.Point(1027, 659);
            this.pButton11.Name = "pButton11";
            this.pButton11.Size = new System.Drawing.Size(113, 44);
            this.pButton11.TabIndex = 21;
            this.pButton11.Text = "(F9)";
            this.pButton11.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(75, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "စာရေးကိရိယာ ဖြန့်ချီရောင်း၀ယ်ရေး";
            // 
            // BaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 709);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pButton11);
            this.Controls.Add(this.pButton8);
            this.Controls.Add(this.pButton9);
            this.Controls.Add(this.pButton10);
            this.Controls.Add(this.pButton4);
            this.Controls.Add(this.pButton5);
            this.Controls.Add(this.pButton6);
            this.Controls.Add(this.pButton7);
            this.Controls.Add(this.pButton2);
            this.Controls.Add(this.pButton3);
            this.Controls.Add(this.pButton1);
            this.Controls.Add(this.pButton13);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseFrm";
            this.Text = "BaseFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaseFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tspLoginUser;
        private ToolStripMenuItem tspCurrentDate;
        private ToolStripMenuItem tspLogOut;
        private POS_Control.PButton pButton1;
        private POS_Control.PButton pButton2;
        private POS_Control.PButton pButton3;
        private POS_Control.PButton pButton4;
        private POS_Control.PButton pButton5;
        private POS_Control.PButton pButton6;
        private POS_Control.PButton pButton7;
        private POS_Control.PButton pButton8;
        private POS_Control.PButton pButton9;
        private POS_Control.PButton pButton10;
        private POS_Control.PButton pButton13;
        private POS_Control.PButton pButton11;
        private Label label1;
        private Label label2;
    }
}