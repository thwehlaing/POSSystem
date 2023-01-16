namespace POSBase
{
    partial class BaseForm
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
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnF1 = new POS_Control.PButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnF2 = new POS_Control.PButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Navy;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 57);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspLoginUser,
            this.tspCurrentDate});
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
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(212, 54);
            this.toolStripMenuItem5.Text = "ထိန်းချုပ်မှု";
            // 
            // BtnF1
            // 
            this.BtnF1.BackColor = System.Drawing.Color.White;
            this.BtnF1.ButtonType = Entity.ButtonType.BType.Normal;
            this.BtnF1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnF1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnF1.Location = new System.Drawing.Point(3, 3);
            this.BtnF1.Name = "BtnF1";
            this.BtnF1.Size = new System.Drawing.Size(130, 48);
            this.BtnF1.TabIndex = 38;
            this.BtnF1.Text = "(F1)";
            this.BtnF1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.16329F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.67429F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.16243F));
            this.tableLayoutPanel3.Controls.Add(this.BtnF1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnF2, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 695);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1370, 54);
            this.tableLayoutPanel3.TabIndex = 39;
            // 
            // BtnF2
            // 
            this.BtnF2.BackColor = System.Drawing.Color.White;
            this.BtnF2.ButtonType = Entity.ButtonType.BType.Normal;
            this.BtnF2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnF2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnF2.Location = new System.Drawing.Point(1233, 3);
            this.BtnF2.Name = "BtnF2";
            this.BtnF2.Size = new System.Drawing.Size(130, 48);
            this.BtnF2.TabIndex = 39;
            this.BtnF2.Text = "(F1)";
            this.BtnF2.UseVisualStyleBackColor = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tspLoginUser;
        private ToolStripMenuItem tspCurrentDate;
        private ToolStripMenuItem toolStripMenuItem5;
        private TableLayoutPanel tableLayoutPanel2;
        private POS_Control.PButton BtnF1;
        private POS_Control.PButton pButton12;
        private TableLayoutPanel tableLayoutPanel3;
        private POS_Control.PButton BtnF2;
    }
}