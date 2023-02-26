using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSBase;
using Entity;
using BL;   

namespace Category
{
    public partial class CategoryList : BaseForm
    {
        BaseBL bbl = new BaseBL();
        public CategoryList()
        {
            InitializeComponent();
        }

        private void CategoryList_Load(object sender, EventArgs e)
        {
            ProgramID = "CategoryList";
            ProgramName = "ပစ္စည်းအမျိုးအစား ပြခြင်း";
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "ပြခြင်း", true);
            DBProcess();
        }

        public override void FunctionProcess(string tagID)
        {
            if (tagID == "2")
            {
                if (ErrorCheck(PanelDetail))
                {
                    DBProcess();
                }
            }
            base.FunctionProcess(tagID);
        }

        private void DBProcess()
        {          
            CategoryBL bl = new CategoryBL();
            dgvCategory.Rows.Clear();
            DataTable dt = bl.Category_Select();

            if (dt.Rows.Count > 0)
                dgvCategory.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvCategory.Rows[i].Cells["CatCD"].Value = dt.Rows[i]["CategoryCD"].ToString();
                dgvCategory.Rows[i].Cells["CatName"].Value = dt.Rows[i]["CategoryName"].ToString();
            }
        }


        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (bbl.ShowMessage("Q004") == DialogResult.Yes)
                {
                    CategoryBL bl = new CategoryBL();
                    CategoryEntity obj = new CategoryEntity();
                    obj.CategoryCD = dgvCategory.Rows[e.RowIndex].Cells["CatCD"].Value.ToString();
                    obj.UpdatedUser = obj.OperatorCD;
                    bool return_Bl = bl.Category_Delete(obj);
                    if (return_Bl)
                    {
                        dgvCategory.Rows.RemoveAt(e.RowIndex);
                        bbl.ShowMessage("I102");
                    }
                }
            }
        }
    }
}
