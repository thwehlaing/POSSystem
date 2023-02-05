using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Search
{
    public partial class SubCategory_Search : Search_Base
    {
        public SubCategory_Search()
        {
            InitializeComponent();
            Search_Form_Name = "ပစ္စည်းအမျိုးအစား(ခွဲ)";
        }

        private void SubCategory_Search_Load(object sender, EventArgs e)
        {
            //dgvSubCategory.UseRowNo(true);
            //dgvSubCategory.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
