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
using POSBase;

namespace StockPackaging
{
    public partial class StockPackagingList : BaseForm
    {
        public StockPackagingList()
        {
            InitializeComponent();
        }

        private void StockPackagingList_Load(object sender, EventArgs e)
        {
            ProgramID = "StockPackagingList";
            ProgramName = "ကုန်ပစ္စည်း ထုပ်ပိုးခြင်း စာရင်း";
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "ပြမည်", true);
            BindSubCatgory();
        }


        private void BindSubCatgory()
        {
            SubCategoryBL scbl = new SubCategoryBL();
            DataTable dtSubCategory = new DataTable();
            dtSubCategory = scbl.SubCategory_SelectAll();
            DataRow dr = dtSubCategory.NewRow();
            dr["SubCode"] = "-1";
            dtSubCategory.Rows.InsertAt(dr, 0);
            cboSubCategory.DataSource = dtSubCategory;
            cboSubCategory.DisplayMember = "SubName";
            cboSubCategory.ValueMember = "SubCode";
        }
        private void BindStockItemBySubCategory()
        {
            StockItemBL scbl = new StockItemBL();
            StockItemEntity obj = new StockItemEntity();
            obj.SubCode = cboSubCategory.SelectedValue.ToString();
            DataTable dtstockitem = new DataTable();
            dtstockitem = scbl.StockItem_SelectBySubCategory(obj);
            DataRow dr = dtstockitem.NewRow();
            dr["ItemCD"] = "-1";
            dtstockitem.Rows.InsertAt(dr, 0);
            cboStockItem.DataSource = dtstockitem;
            cboStockItem.DisplayMember = "ItemName";
            cboStockItem.ValueMember = "ItemCD";
        }
        public override void FunctionProcess(string tagID)
        {
            if (tagID == "2")
            {
                BindDataGridView();
            }
            base.FunctionProcess(tagID);
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            BindDataGridView();
        }

        private void BindDataGridView()
        {
            StockPackagingBL bl = new StockPackagingBL();
            StockPackagingEntity obj = GetStockPackagingList();
            DataTable dt = bl.StockPackaging_Select(obj);
            if (dt.Rows.Count > 0)
                dgvStockPackaging.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvStockPackaging.Rows[i].Cells["ItemCD"].Value = dt.Rows[i]["ItemCD"].ToString();
                dgvStockPackaging.Rows[i].Cells["PackTypeCode"].Value = dt.Rows[i]["PackTypeCode"].ToString();
                dgvStockPackaging.Rows[i].Cells["Qty"].Value = dt.Rows[i]["Qty"].ToString();
                dgvStockPackaging.Rows[i].Cells["OpenQty"].Value = dt.Rows[i]["OpenQty"].ToString();
            }
        }

        private StockPackagingEntity GetStockPackagingList()
        {
            StockPackagingEntity obj = new StockPackagingEntity();  
            if(cboStockItem.SelectedValue != "-1")
                obj.ItemCD = cboStockItem.SelectedValue.ToString();
            return obj;
        }

        private void cboSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSubCategory.SelectedValue != "-1")
            {
                BindStockItemBySubCategory();
            }
        }

        private void ClearData()
        {
            cboSubCategory.SelectedValue = "-1";
            cboStockItem.SelectedValue = "-1";
        }
    }
}
