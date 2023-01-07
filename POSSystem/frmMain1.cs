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
    public partial class frmMain1 : Form
    {
        public frmMain1()
        {
            InitializeComponent();         
            tspCurrentDate.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMain1_Load(object sender, EventArgs e)
        {

        }

        private void tsMUser_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            user.Show();
        }

        private void tspMenuCategory_Click(object sender, EventArgs e)
        {
            frmCategory frmcat = new frmCategory();
            frmcat.Show();
        }

        private void tspSubCategoryMenu_Click(object sender, EventArgs e)
        {
            frmSubCategory frmsubCat = new frmSubCategory();
            frmsubCat.Show();
        }
    }
}
