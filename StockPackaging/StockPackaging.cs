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
    public partial class StockPackaging : BaseForm
    {
        public StockPackaging()
        {
            InitializeComponent();
        }

        private void StockPackaging_Load(object sender, EventArgs e)
        {
            ProgramID = "StockPackaging";
            ProgramName = "ကုန်ပစ္စည်း ထုပ်ပိုးခြင်း";
            PreviousCtrl = cboSubCategory;
            cboSubCategory.Focus();
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "သိမ်းမည်", true);
            BindSubCatgory();           
            BindPackagingType();
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

        private void BindPackagingType()
        {
            PackagingTypeBL ptcbl = new PackagingTypeBL();           
            DataTable dtpackagingtype = new DataTable();
            dtpackagingtype = ptcbl.PackagingType_Select();
            DataRow dr = dtpackagingtype.NewRow();
            dr["PackTypeCode"] = "-1";
            dtpackagingtype.Rows.InsertAt(dr, 0);
            cboPackagingType.DataSource = dtpackagingtype;
            cboPackagingType.DisplayMember = "PackTypeName";
            cboPackagingType.ValueMember = "PackTypeCode";
        }

        private void ErrorCheck()
        {
            cboSubCategory.CheckRequired(true);
            cboItemName.CheckRequired(true);
            cboPackagingType.CheckRequired(true);
            txtQty.CheckRequired(true);
        }
        public override void FunctionProcess(string tagID)
        {
            if(tagID == "2")
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
            StockPackagingEntity obj = GetInsertStockPackaging();           
            StockPackagingBL bl = new StockPackagingBL();
            bool result = bl.StockPackaging_Insert(obj);
            if (result)
            {
                bl.ShowMessage("I101");
                ClearData();
            }
        }

        private StockPackagingEntity GetInsertStockPackaging()
        {
            StockPackagingEntity obj = new StockPackagingEntity();
            obj.ItemCD = cboItemName.SelectedValue.ToString();
            obj.PackTypeCode = cboPackagingType.SelectedValue.ToString();
            obj.PackQty = Convert.ToInt32(txtQty.Text);
            obj.CreatedUser = obj.OperatorCD;
            return obj;
        }
        private void ClearData()
        {
            cboSubCategory.SelectedValue = "-1";
            cboItemName.SelectedValue = "-1";
            cboPackagingType.SelectedValue = "-1";
            txtQty.Text = "";
        }

        private void cboSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSubCategory.SelectedValue !="-1") 
            { 
                BindStockItemBySubCategory();
            }
        }
    }
}
