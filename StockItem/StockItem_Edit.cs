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
using POS_Search;

namespace StockItem
{
    public partial class StockItem_Edit : BaseForm
    {
        public StockItem_Edit()
        {
            InitializeComponent();
        }

        private void StockItem_Edit_Load(object sender, EventArgs e)
        {
            ProgramID = "StockItem Edit";
            ProgramName = "ကုန်ပစ္စည်းအမျိုးအစား ပြင်ဆင်ခြင်း";
            PreviousCtrl = cboSubCategory;
            cboSubCategory.Focus();
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "သိမ်းမည်", true);
            BindSubCatgory();
            BindUOM();
            ErrorCheck();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!cboSubCategory.IsErrorOccurs)
            {
                StockItem_Search search = new StockItem_Search(cboSubCategory.SelectedValue.ToString(), cboSubCategory.Text);
                search.ShowDialog();
                txtQty.Text = search.Quantity.ToString();
                txtStockName.Text = search.ItmName;
                txtPrice.Text = search.SalePrice.ToString();
                txtReorderQty.Text = search.RQty.ToString();
                cboUOM.SelectedValue = search.UOMCode;
                txtBarCode.Text = search.BCode;
            }
        }
        private void ErrorCheck()
        {
            cboSubCategory.CheckRequired(true);
            txtStockName.CheckRequired(true);
            cboUOM.CheckRequired(true);
            txtQty.CheckRequired(true);
            txtPrice.CheckRequired(true);
            txtBarCode.CheckRequired(true);
            txtReorderQty.CheckRequired(true);
        }
        private void ClearData()
        {
            cboSubCategory.SelectedIndex = -1;
            txtStockName.Text = "";
            cboUOM.SelectedIndex = -1;
            txtQty.Text = "";
            txtPrice.Text = "";
            txtBarCode.Text = "";
            txtReorderQty.Text = "";
        }
    }
}
