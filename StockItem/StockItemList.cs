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

namespace StockItem
{
    public partial class StockItemList : BaseForm
    {
        public StockItemList()
        {
            InitializeComponent();
        }

        private void StockItemList_Load(object sender, EventArgs e)
        {
            ProgramID = "StockItemList";
            ProgramName = "ကုန်ပစ္စည်းအမျိုးအစား စာရင်း";
            PreviousCtrl = cboSubCategory;
            cboSubCategory.Focus();
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "ပြမည်", true);
            cboSubCategory.CheckRequired(true);
            BindSubCatgory();
            DBProcess();
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

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (!cboSubCategory.IsErrorOccurs)
            {
                DBProcess();
            }
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
            StockItemEntity obj = GetStockItem();
            StockItemBL bl = new StockItemBL();
            dgvStockItem.Rows.Clear();
            DataTable dt = bl.StockItem_Search(obj);
            if (dt.Rows.Count > 0)
                dgvStockItem.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvStockItem.Rows[i].Cells["ItemCD"].Value = dt.Rows[i]["ItemCD"].ToString();               
                dgvStockItem.Rows[i].Cells["SubName"].Value = dt.Rows[i]["SubName"].ToString();
                dgvStockItem.Rows[i].Cells["ItemName"].Value = dt.Rows[i]["ItemName"].ToString();
                dgvStockItem.Rows[i].Cells["Qty"].Value = dt.Rows[i]["Qty"].ToString();
                dgvStockItem.Rows[i].Cells["UOMName"].Value = dt.Rows[i]["UOMName"].ToString();
                dgvStockItem.Rows[i].Cells["LastSalePrice"].Value = dt.Rows[i]["LastSalePrice"].ToString();
                dgvStockItem.Rows[i].Cells["ReorderQty"].Value = dt.Rows[i]["ReorderQty"].ToString();
                dgvStockItem.Rows[i].Cells["BarCode"].Value = dt.Rows[i]["BarCode"].ToString();
            }
        }

        private StockItemEntity GetStockItem()
        {
            StockItemEntity obj = new StockItemEntity();
            obj.SubCode = cboSubCategory.SelectedValue.ToString()=="-1"?"": cboSubCategory.SelectedValue.ToString();
            obj.ItemName = txtName.Text;
            return obj;
        }

        private void dgvStockItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                StockItemBL bl = new StockItemBL();
                if (bl.ShowMessage("Q004") == DialogResult.Yes)
                {                    
                    StockItemEntity obj = new StockItemEntity();
                    obj.ItemCD = dgvStockItem.Rows[e.RowIndex].Cells["ItemCD"].Value.ToString();
                    obj.UpdatedUser = obj.OperatorCD;
                    bool return_Bl = bl.StockItem_Delete(obj);
                    if (return_Bl)
                    {
                        dgvStockItem.Rows.RemoveAt(e.RowIndex);
                        bl.ShowMessage("I102");
                    }
                }
            }
        }
    }
}
