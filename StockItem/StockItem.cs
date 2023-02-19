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
using POSBase;


namespace StockItem
{
    public partial class StockItem : BaseForm
    {
        public StockItem()
        {
            InitializeComponent();
        }

        private void StockItem_Load(object sender, EventArgs e)
        {
            ProgramID = "StockItem";
            ProgramName = "ကုန်ပစ္စည်းအမျိုးအစား";
            StartProgram();
            PreviousCtrl = cboSubCategory;
            cboSubCategory.Focus();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "သိမ်းမည်", true);
            ErrorCheck();
            BindSubCatgory();
            BindUOM();
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
            StockItemEntity obj = GetInsertStockItem();
            StockItemBL bl = new StockItemBL();
            bool return_Bl = bl.StockItem_Create(obj);
            if (return_Bl)
            {
                bl.ShowMessage("I101");
                ClearData();
            }
        }

        private StockItemEntity GetInsertStockItem()
        {
            StockItemEntity entity = new StockItemEntity();
            entity.ItemName = txtStockName.Text;
            entity.SubCode = cboSubCategory.SelectedValue.ToString();
            entity.UOMCD = cboUOM.SelectedValue.ToString();
            entity.Qty =Convert.ToInt32(txtQty.Text);
            entity.BarCode = txtBarCode.Text;
            entity.ReOrderQty = Convert.ToInt32(txtReorderQty.Text);
            entity.LastSalePrice = Convert.ToDouble(txtPrice.Text);
            entity.Status = rdo_active.Checked == true ? "1" : "0";
            entity.CreatedUser = entity.OperatorCD;
            entity.ProgramID = entity.ProgramID;
            return entity;
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
