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

namespace PurchaseItem
{
    public partial class PurchaseItem : BaseForm
    {       
        public PurchaseItem()
        {
            InitializeComponent();
        }

        private void PurchaseItem_Load(object sender, EventArgs e)
        {
            ProgramID = "PurchaseItem";
            ProgramName = "အ၀ယ်";
            PreviousCtrl = cboSubCategory;
            cboSubCategory.Focus();
            txtGrandTotal.Text = "0";
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "သိမ်းမည်", true);
            BindSubCatgory();
            BindSupplier();
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

        private void BindPackagingType()
        {
            PackagingTypeBL ptcbl = new PackagingTypeBL();
            DataTable dtpackagingtype = new DataTable();
            dtpackagingtype = ptcbl.PackagingType_Select();
            DataRow dr = dtpackagingtype.NewRow();
            dr["PackTypeCode"] = "-1";
            dtpackagingtype.Rows.InsertAt(dr, 0);
            cboPackType.DataSource = dtpackagingtype;
            cboPackType.DisplayMember = "PackTypeName";
            cboPackType.ValueMember = "PackTypeCode";
        }
        private void BindSupplier()
        {
            SupplierBL sbl = new SupplierBL();
            DataTable dtSupplier = new DataTable();
            dtSupplier = sbl.Supplier_SelectAll();
            DataRow dr = dtSupplier.NewRow();
            dr["SupplierCD"] = "-1";
            dtSupplier.Rows.InsertAt(dr, 0);
            cboSupplier.DataSource = dtSupplier;
            cboSupplier.DisplayMember = "SupplierName";
            cboSupplier.ValueMember = "SupplierCD";
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
        private void cboSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSubCategory.SelectedIndex.ToString() != "0")
            {
                BindStockItemBySubCategory();
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
            PurchaseEntity entity = GetInsertPurchaseItem();
            PurchaseItemBL bl = new PurchaseItemBL();
            bool result = bl.PurchaseItem_Create(entity);
            if (result)
            {
                bl.ShowMessage("I101");
                CleardData();
            }
        }
        private PurchaseEntity GetInsertPurchaseItem()
        {
            PurchaseEntity entity = new PurchaseEntity();
            entity.PurchaseDate = Convert.ToDateTime(dtpPurchaseDate.Text);
            entity.SupplierCD = cboSupplier.SelectedValue.ToString();
            entity.TotalAmt =Convert.ToDouble(txtGrandTotal.Text.ToString().Replace(",", ""));
            entity.PurchaseItem = GetDataTable();
            for (int i = 0; i < dgvPurchaseItem.Rows.Count; i++)
            {
                entity.PurchaseItem.Rows.Add();
                entity.PurchaseItem.Rows[i]["ItemCD"] = dgvPurchaseItem.Rows[i].Cells["ItemCD"].Value;
                entity.PurchaseItem.Rows[i]["PackTypeCode"] = dgvPurchaseItem.Rows[i].Cells["PackTypeCode"].Value;
                //entity.PurchaseItem.Rows[i]["QtyPerPack"] = dgvPurchaseItem.Rows[i].Cells["QtyPerPack"].Value;
                entity.PurchaseItem.Rows[i]["UOMQty"] = (Convert.ToInt32(dgvPurchaseItem.Rows[i].Cells["QtyPerPack"].Value)* Convert.ToInt32(dgvPurchaseItem.Rows[i].Cells["Qty"].Value));
                entity.PurchaseItem.Rows[i]["UOMPrice"] = dgvPurchaseItem.Rows[i].Cells["UOMPrice"].Value.ToString().Replace(",","");
                entity.PurchaseItem.Rows[i]["PackQty"] = dgvPurchaseItem.Rows[i].Cells["Qty"].Value;
                entity.PurchaseItem.Rows[i]["PackPrice"] = dgvPurchaseItem.Rows[i].Cells["PackPrice"].Value.ToString().Replace(",", "");
            }

            return entity;
        }
        public DataTable GetDataTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("ItemCD", typeof(string));           
            dt.Columns.Add("PackTypeCode", typeof(string));
            //dt.Columns.Add("QtyPerPack", typeof(string));
            dt.Columns.Add("UOMQty", typeof(int));
            dt.Columns.Add("UOMPrice", typeof(double));
            dt.Columns.Add("PackQty", typeof(string));
            dt.Columns.Add("PackPrice", typeof(int));
            return dt;
        }

        private void CleardData()
        {
            cboSubCategory.SelectedValue = "-1";
            cboItemName.SelectedValue = "-1";
            cboPackType.SelectedValue = "-1";
            txtQtyPerPack.Text = "";
            txtUOMPrice.Text = "";
            txtQty.Text = "";
            txtPackPrice.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ErrorCheck(pnlHeading))
            {
                int rowId = dgvPurchaseItem.Rows.Add();
                DataGridViewRow row = dgvPurchaseItem.Rows[rowId];
                dgvPurchaseItem.Rows[rowId].Cells["ItemCD"].Value = cboItemName.SelectedValue;
                dgvPurchaseItem.Rows[rowId].Cells["PackTypeCode"].Value = cboPackType.SelectedValue;
                dgvPurchaseItem.Rows[rowId].Cells["ItemName"].Value = cboItemName.Text;
                dgvPurchaseItem.Rows[rowId].Cells["PackTypeName"].Value = cboPackType.Text;
                dgvPurchaseItem.Rows[rowId].Cells["QtyPerPack"].Value = txtQtyPerPack.Text;
                dgvPurchaseItem.Rows[rowId].Cells["PackPrice"].Value = Convert.ToInt32(txtPackPrice.Text).ToString("#,##0");
                dgvPurchaseItem.Rows[rowId].Cells["UOMPrice"].Value =(Convert.ToInt32(txtPackPrice.Text)/Convert.ToInt32(txtQtyPerPack.Text)).ToString("#,##0");
                dgvPurchaseItem.Rows[rowId].Cells["Qty"].Value = txtQty.Text;
                dgvPurchaseItem.Rows[rowId].Cells["TotalPrice"].Value = (Convert.ToInt32(txtPackPrice.Text) * Convert.ToInt32(txtQty.Text)).ToString("#,##0");
                int GTotal = Convert.ToInt32(txtGrandTotal.Text.Replace(",",""));
                txtGrandTotal.Text = (GTotal + (Convert.ToInt32(txtPackPrice.Text) * Convert.ToInt32(txtQty.Text))).ToString("#,##0");
                CleardData();
            }
        }

        private void cboPackType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPackType.SelectedIndex.ToString() != "0")
            {
                PackagingTypeBL ptbl = new PackagingTypeBL();
                DataTable dtQtyPerPack= ptbl.BindQtyPerPack(cboPackType.SelectedValue.ToString());
                txtQtyPerPack.Text = dtQtyPerPack.Rows[0]["UOMQty"].ToString();
            }
        }

        private void ErrorCheck()
        {
            cboSubCategory.CheckRequired(true);
            cboItemName.CheckRequired(true);
            cboPackType.CheckRequired(true);
            txtQty.CheckRequired(true);
            txtPackPrice.CheckRequired(true);
            cboSupplier.CheckRequired(true);
            txtGrandTotal.CheckRequired(true);
        }

    }
}
