using POSBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        protected override void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            switch (menuItem.Name)
            {
                case "tspSale":
                    //frmCategory frmCat = new frmCategory();
                    //frmCat.Show();
                    break;
                case "tspInvoice":
                    //frmSubCategory frmSubCat = new frmSubCategory();
                    //frmSubCat.Show();
                    break;
                case "tspDamage":
                    //frmCategory frmCat = new frmCategory();
                    //frmCat.Show();
                    break;
                case "tspPurchase":
                    //frmSubCategory frmSubCat = new frmSubCategory();
                    //frmSubCat.Show();
                    break;
                case "tspRepackage":
                    //frmCategory frmCat = new frmCategory();
                    //frmCat.Show();
                    break;
                case "tspStockLedger":
                    //frmSubCategory frmSubCat = new frmSubCategory();
                    //frmSubCat.Show();
                    break;
                case "tspCashLedger":
                    //frmCategory frmCat = new frmCategory();
                    //frmCat.Show();
                    break;
                case "tspDailyRpt":
                    //frmSubCategory frmSubCat = new frmSubCategory();
                    //frmSubCat.Show();
                    break;
                case "tspMonthlyRpt":
                    //frmCategory frmCat = new frmCategory();
                    //frmCat.Show();
                    break;
                case "tspYearlyRpt":
                    //frmSubCategory frmSubCat = new frmSubCategory();
                    //frmSubCat.Show();
                    break;
                case "tspCategory":
                    frmCategory frmCat = new frmCategory();
                    frmCat.Show();
                    break;
                case "tspSubCategory":
                    frmSubCategory frmSubCat = new frmSubCategory();
                    frmSubCat.Show();
                    break;
                case "tspStock":
                    //frmSubCategory frmSubCat = new frmSubCategory();
                    //frmSubCat.Show();
                    break;
                case "tspSupplier":
                    //frmCategory frmCat = new frmCategory();
                    //frmCat.Show();
                    break;
                case "tspUser":
                    //frmSubCategory frmSubCat = new frmSubCategory();
                    //frmSubCat.Show();
                    break;
                case "tspPackage":
                    //frmSubCategory frmSubCat = new frmSubCategory();
                    //frmSubCat.Show();
                    break;
            }
        }
    }
}
