using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSBase
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            tspCurrentDate.Text ="Date :"+ DateTime.Now.ToString("dd/MM/yyyy");
            tspSaleMenu.MouseEnter += new System.EventHandler(ChangeMenuColor);
            tspSaleMenu.MouseLeave += new System.EventHandler(ChangeBackMenuColor);
            tspPurchaseMenu.MouseEnter += new System.EventHandler(ChangeMenuColor);
            tspPurchaseMenu.MouseLeave += new System.EventHandler(ChangeBackMenuColor);
            tspLedgerMenu.MouseEnter += new System.EventHandler(ChangeMenuColor);
            tspLedgerMenu.MouseLeave += new System.EventHandler(ChangeBackMenuColor);
            tspReportMenu.MouseEnter += new System.EventHandler(ChangeMenuColor);
            tspReportMenu.MouseLeave += new System.EventHandler(ChangeBackMenuColor);
            tspSettingMenu.MouseEnter += new System.EventHandler(ChangeMenuColor);
            tspSettingMenu.MouseLeave += new System.EventHandler(ChangeBackMenuColor);
        }

        private void tspSaleMenu_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }

        private void tspSaleMenu_DropDownOpened(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }

        private void tspSaleMenu_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.Black;
        }

        private void tspSaleMenu_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.White;
        }
        private void ChangeMenuColor(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.Black;
        }
        private void ChangeBackMenuColor(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.White;
        }
    }
}
