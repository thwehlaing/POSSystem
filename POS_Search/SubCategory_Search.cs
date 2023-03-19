using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entity;


namespace POS_Search
{
    public partial class SubCategory_Search : Search_Base
    {
        public string CatCD = "";
        public string SubCategoryCD = "";
        public string SubCategoryName = "";
        public string Category_Name = "";
        public SubCategory_Search(string CategoryCD,string CategoryName)
        {
            InitializeComponent();
            CatCD = CategoryCD;
            Category_Name = CategoryName;
            Search_Form_Name = "ပစ္စည်းအမျိုးအစား(ခွဲ)";
        }

        private void SubCategory_Search_Load(object sender, EventArgs e)
        {
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "ယူမည်", true);
            txtCategoryName.Text = Category_Name;
            DataGridviewBind();
        }
       
        private void DataGridviewBind()
        {
            SubCategoryEntity entity = new SubCategoryEntity();
            entity.CategoryCD = CatCD;
            entity.SubName = txtSubCategory.Text;
            SubCategoryBL sbl=new SubCategoryBL();
            DataTable dt = sbl.SubCategory_Search(entity);
            dgvSubCategory.DataSource = dt;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DataGridviewBind();
        }

        private void dgvSubCategory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GetDataGridViewData(dgvSubCategory.Rows[e.RowIndex]);
            }

        }
        public override void FunctionProcess(string tagID)
        {
            if (tagID == "2")
            {
                DataGridViewRow row = dgvSubCategory.CurrentRow;
                GetDataGridViewData(row);
            }
            base.FunctionProcess(tagID);
        }

        private void GetDataGridViewData(DataGridViewRow row)
        {
            if(row != null)
            {                
                SubCategoryCD = row.Cells["SubCode"].Value.ToString();
                Category_Name = row.Cells["CategoryName"].Value.ToString();
                SubCategoryName = row.Cells["SubName"].Value.ToString();
            }
            this.Close();
        }
    }
}
