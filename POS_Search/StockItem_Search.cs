using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BL;

namespace POS_Search
{
    public partial class StockItem_Search : Search_Base
    {
        public string ItmCD = string.Empty;
        public string SCode = string.Empty;
        public string SName = string.Empty;
        public string ItmName = string.Empty;
        public int Quantity = 0;
        public double SalePrice = 0;
        public int RQty = 0;
        public string BCode = string.Empty;
        public string UOMCode = string.Empty;
        public StockItem_Search(string SubCode,string SubName)
        {
            InitializeComponent();
            SCode = SubCode;
            SName = SubName;
        }

        private void StockItem_Search_Load(object sender, EventArgs e)
        {
            txtSubName.Text = SName;
            txtName.Focus();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "ယူမည်", true);
        }       
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DataGridviewBind();
        }
        public override void FunctionProcess(string tagID)
        {
            if (tagID == "2")
            {
                GetDataGridViewData(dgvStockItem.CurrentRow);
            }
            
            base.FunctionProcess(tagID);
        }
        private void DataGridviewBind()
        {
            StockItemEntity entity = new StockItemEntity();
            entity.SubCode = SCode;
            entity.ItemName = txtName.Text;
            StockItemBL sbl = new StockItemBL();
            dgvStockItem.Rows.Clear();
            DataTable dt = sbl.StockItem_Search(entity);
            if (dt.Rows.Count > 0)
                dgvStockItem.Rows.Add(dt.Rows.Count);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                dgvStockItem.Rows[i].Cells["ItemCD"].Value = dt.Rows[i]["ItemCD"].ToString();
                dgvStockItem.Rows[i].Cells["UOMCD"].Value = dt.Rows[i]["UOMCD"].ToString();
                dgvStockItem.Rows[i].Cells["SubName"].Value = dt.Rows[i]["SubName"].ToString();
                dgvStockItem.Rows[i].Cells["ItemName"].Value = dt.Rows[i]["ItemName"].ToString();
                dgvStockItem.Rows[i].Cells["Qty"].Value = dt.Rows[i]["Qty"].ToString();
                dgvStockItem.Rows[i].Cells["UOMName"].Value = dt.Rows[i]["UOMName"].ToString();
                dgvStockItem.Rows[i].Cells["LastSalePrice"].Value = dt.Rows[i]["LastSalePrice"].ToString();
                dgvStockItem.Rows[i].Cells["ReorderQty"].Value = dt.Rows[i]["ReorderQty"].ToString();
                dgvStockItem.Rows[i].Cells["BarCode"].Value = dt.Rows[i]["BarCode"].ToString();
            }
        }

        private void dgvStockItem_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GetDataGridViewData(dgvStockItem.Rows[e.RowIndex]);
            }
        }
        private void GetDataGridViewData(DataGridViewRow row)
        {
            if (row != null)
            {
                ItmCD = row.Cells["ItemCD"].Value.ToString();
                ItmName = row.Cells["ItemName"].Value.ToString();
                Quantity =Convert.ToInt32(row.Cells["Qty"].Value.ToString());
                UOMCode = row.Cells["UOMCD"].Value.ToString();
                SalePrice = Convert.ToDouble(row.Cells["LastSalePrice"].Value.ToString());
                RQty = Convert.ToInt32(row.Cells["ReorderQty"].Value.ToString());                
                BCode = row.Cells["BarCode"].Value.ToString();
            }
            this.Close();
        }
    }
}
