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
using BL;
using Entity;

namespace SubCategory
{
    public partial class SubCategoryList : BaseForm
    {
        BaseBL bbl = new BaseBL();
        public SubCategoryList()
        {
            InitializeComponent();
        }


        private void SubCategoryList_Load(object sender, EventArgs e)
        {
            ProgramID = "SubCategoryList";
            ProgramName = "ပစ္စည်းအမျိုးအစား(ခွဲ) ပြခြင်း";
            PreviousCtrl = cboCategory;
            cboCategory.Focus();
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "ပြခြင်း", true);
            BindCatgory();
            ErrorCheck();
        }

        private void BindCatgory()
        {
            CategoryBL cbl = new CategoryBL();
            DataTable dtCategory = new DataTable();
            dtCategory = cbl.Category_Select();
            DataRow dr = dtCategory.NewRow();
            dr["CategoryCD"] = "-1";
            dtCategory.Rows.InsertAt(dr, 0);
            cboCategory.DataSource = dtCategory;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryCD";
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
            SubCategoryEntity obj = GetCategory();
            SubCategoryBL bl = new SubCategoryBL();
            DataTable dt = bl.SubCategory_Select(obj);            
            dgvSubcategory.DataSource = dt;
        }

        private SubCategoryEntity GetCategory()
        {
            SubCategoryEntity obj = new SubCategoryEntity();
            obj.CategoryCD = cboCategory.SelectedValue.ToString();          
            obj.SubName = txtSubName.Text;           
            return obj;
        }
        public void ErrorCheck()
        {
            cboCategory.CheckRequired(true);            
        }

        public void ClearData()
        {
            cboCategory.SelectedIndex = -1;
            txtSubName.Text = "";
        }

        private void dgvSubcategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {              
                if (bbl.ShowMessage("Q004") == DialogResult.Yes)
                {
                    SubCategoryBL bl = new SubCategoryBL();
                    SubCategoryEntity obj = new SubCategoryEntity();
                    obj.SubCode = dgvSubcategory.Rows[e.RowIndex].Cells["SubCode"].Value.ToString();
                    obj.UpdatedUser = obj.OperatorCD;
                    bool return_Bl = bl.SubCategory_Delete(obj);
                    if (return_Bl)
                    {
                        dgvSubcategory.Rows.RemoveAt(e.RowIndex);
                        bbl.ShowMessage("I102");                        
                    }
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (ErrorCheck(PanelDetail))
            {
                DBProcess();
            }
        }
    }
}
