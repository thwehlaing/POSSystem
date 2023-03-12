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
            BindDataGridView();
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
            dgvStockPackaging.Rows.Clear();
            if (dt.Rows.Count > 0)
                dgvStockPackaging.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvStockPackaging.Rows[i].Cells["ItemCD"].Value = dt.Rows[i]["ItemCD"].ToString();
                dgvStockPackaging.Rows[i].Cells["PackTypeCode"].Value = dt.Rows[i]["PackTypeCode"].ToString();
                dgvStockPackaging.Rows[i].Cells["ItemName"].Value = dt.Rows[i]["ItemName"].ToString();
                dgvStockPackaging.Rows[i].Cells["PackTypeName"].Value = dt.Rows[i]["PackTypeName"].ToString();
                dgvStockPackaging.Rows[i].Cells["PackQty"].Value = dt.Rows[i]["PackQty"].ToString();
                dgvStockPackaging.Rows[i].Cells["OpenQty"].Value = dt.Rows[i]["OpenQty"].ToString();
                DataGridViewButtonCell btnEdit = (DataGridViewButtonCell)dgvStockPackaging.Rows[i].Cells["btnEdit"];
                btnEdit.Value = "ပြင်ဆင်ရန်";
                DataGridViewButtonCell btnDelete = (DataGridViewButtonCell)dgvStockPackaging.Rows[i].Cells["btnDelete"];
                btnDelete.Value = "ပယ်ဖျက်ရန်";
            }
        }

        private StockPackagingEntity GetStockPackagingList()
        {
            StockPackagingEntity obj = new StockPackagingEntity();
            if (cboStockItem.SelectedValue != "-1")
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

        private void dgvStockPackaging_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex].Name == "btnDelete")
                {
                    StockPackagingBL bl = new StockPackagingBL();
                    if (bl.ShowMessage("Q004") == DialogResult.Yes)
                    {
                        StockPackagingEntity obj = new StockPackagingEntity();
                        obj.ItemCD = dgvStockPackaging.Rows[e.RowIndex].Cells["ItemCD"].Value.ToString();
                        obj.PackTypeCode = dgvStockPackaging.Rows[e.RowIndex].Cells["PackTypeCode"].Value.ToString();
                        bool return_Bl = bl.StockPackaging_Delete(obj);
                        if (return_Bl)
                        {
                            dgvStockPackaging.Rows.RemoveAt(e.RowIndex);
                            bl.ShowMessage("I102");
                        }
                    }
                }
                else if(senderGrid.Columns[e.ColumnIndex].Name == "btnEdit")
                {                  
                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    if (buttonCell.Value.ToString() == "ပြင်ဆင်ရန်")
                    {
                        senderGrid.CurrentCell = senderGrid.Rows[e.RowIndex].Cells[2];
                        senderGrid.Rows[e.RowIndex].Cells["PackQty"].Selected = true;
                        senderGrid.BeginEdit(true);
                        //DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        buttonCell.Value = "သိမ်းမည်";
                    }
                    else
                    {
                        StockPackagingBL bl = new StockPackagingBL();
                        StockPackagingEntity obj = new StockPackagingEntity();
                        obj.ItemCD = dgvStockPackaging.Rows[e.RowIndex].Cells["ItemCD"].Value.ToString();
                        obj.PackTypeCode = dgvStockPackaging.Rows[e.RowIndex].Cells["PackTypeCode"].Value.ToString();
                        obj.PackQty = Convert.ToInt32(dgvStockPackaging.Rows[e.RowIndex].Cells["PackQty"].Value.ToString());
                        obj.UpdatedUser = obj.OperatorCD;
                        bool return_Bl = bl.StockPackaging_Update(obj);
                        if (return_Bl)
                        {
                            bl.ShowMessage("I101");
                            BindDataGridView();
                        }
                    }          
                } 
            }
        }
    }
}
