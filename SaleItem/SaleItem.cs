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

namespace SaleItem
{
    public partial class SaleItem : BaseForm
    {
        public SaleItem()
        {
            InitializeComponent();
        }

        private void SaleItem_Load(object sender, EventArgs e)
        {
            ProgramID = "SaleItem";
            ProgramName = "အရောင်း";
            PreviousCtrl = cboSubCategory;
            cboSubCategory.Focus();
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "သိမ်းမည်", true);
            BindSubCatgory();
            BindUOM();
            BindCashType();
            BindTradeType();
            ErrorCheck();
        }
        private void ErrorCheck()
        {
            cboSubCategory.CheckRequired(true);
            cboItemName.CheckRequired(true);
            cboCashType.CheckRequired(true);
            cboUOM.CheckRequired(true);
            cboTradeType.CheckRequired(true);
            txtQty.CheckRequired(true);
            txtPrice.CheckRequired(true);
            //dtpSaleDate.CheckRequired(true);
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
            cboItemName.DataSource = dtstockitem;
            cboItemName.DisplayMember = "ItemName";
            cboItemName.ValueMember = "ItemCD";
        }
        private void BindUOM()
        {
            StockItemBL stbl = new StockItemBL();
            DataTable dtUOM = new DataTable();
            dtUOM = stbl.UOM_Select();
            DataRow dr = dtUOM.NewRow();
            dr["UOMCD"] = "-1";
            dtUOM.Rows.InsertAt(dr, 0);
            cboUOM.DataSource = dtUOM;
            cboUOM.DisplayMember = "UOMName";
            cboUOM.ValueMember = "UOMCD";
        }
        private void BindCashType()
        {
            SaleItemBL sibl = new SaleItemBL();
            DataTable dtCashType = new DataTable();
            dtCashType = sibl.CashType_Select();
            DataRow dr = dtCashType.NewRow();
            dr["CashCD"] = "-1";
            dtCashType.Rows.InsertAt(dr, 0);
            cboCashType.DataSource = dtCashType;
            cboCashType.DisplayMember = "CashType";
            cboCashType.ValueMember = "CashCD";
        }
        private void BindTradeType()
        {
            SaleItemBL sibl = new SaleItemBL();
            DataTable dtTradeType = new DataTable();
            dtTradeType = sibl.TradeType_Select();
            DataRow dr = dtTradeType.NewRow();
            dr["TradeCD"] = "-1";
            dtTradeType.Rows.InsertAt(dr, 0);
            cboTradeType.DataSource = dtTradeType;
            cboTradeType.DisplayMember = "TradeType";
            cboTradeType.ValueMember = "TradeCD";
        }
        private void cboSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSubCategory.SelectedValue != "-1")
            {
                BindStockItemBySubCategory();
            }
        }
    }
}
