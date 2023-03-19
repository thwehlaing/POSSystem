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
    public partial class Category_Search : Search_Base
    {
       public string CategoryCD = string.Empty;
       public string Category_Name = string.Empty;
        public Category_Search()
        {
            InitializeComponent();
            Search_Form_Name = "ပစ္စည်းအမျိုးအစား";
        }

        private void Category_Search_Load(object sender, EventArgs e)
        {
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "ယူမည်", true);
            DataGridviewBind();
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DataGridviewBind();
        }

        private void DataGridviewBind()
        {
            CategoryEntity entity = new CategoryEntity();           
            entity.CategoryName = txtCategoryName.Text;
            CategoryBL sbl = new CategoryBL();
            dgvCategory.Rows.Clear();
            DataTable dt = sbl.Category_Search(entity);
            if (dt.Rows.Count > 0)
                dgvCategory.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvCategory.Rows[i].Cells["CatCD"].Value = dt.Rows[i]["CategoryCD"].ToString();
                dgvCategory.Rows[i].Cells["CatName"].Value = dt.Rows[i]["CategoryName"].ToString();                
            }
        }

        private void dgvCategory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GetDataGridViewData(dgvCategory.Rows[e.RowIndex]);
            }
        }

        public override void FunctionProcess(string tagID)
        {
            if (tagID == "2")
            {
                DataGridViewRow row = dgvCategory.CurrentRow;
                GetDataGridViewData(row);
            }
            base.FunctionProcess(tagID);
        }

        private void GetDataGridViewData(DataGridViewRow row)
        {
            if (row != null)
            {
                CategoryCD = row.Cells["CatCD"].Value.ToString();
                Category_Name = row.Cells["CatName"].Value.ToString();                
            }
            this.Close();
        }
    }
}
