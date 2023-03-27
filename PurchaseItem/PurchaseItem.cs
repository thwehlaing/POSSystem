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
            StartProgram();
            SetButton(ButtonType.BType.Close, F1, "ပိတ်မည်", true);
            SetButton(ButtonType.BType.Save, F2, "သိမ်းမည်", true);
            BindSubCatgory();
            BindSupplier();
            BindPackagingType();
            //ErrorCheck();
        }
        private void ErrorCheck()
        {
            cboSubCategory.CheckRequired(true);
            cboItemName.CheckRequired(true);            
            txtQtyPerPack.CheckRequired(true);
            txtUOMPrice.CheckRequired(true);
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
            PurchaseItemEntity entity = GetInsertPurchaseItem();
            PurchaseItemBL bl = new PurchaseItemBL();
            bool result = bl.PurchaseItem_Create(entity);
            if (result)
            {
                bl.ShowMessage("I101");
                CleardData();
            }
        }
        private PurchaseItemEntity GetInsertPurchaseItem()
        {
            PurchaseItemEntity entity = new PurchaseItemEntity();
            entity.ItemCD = cboItemName.SelectedValue.ToString();          
            entity.UOMQty = Convert.ToInt32(txtQtyPerPack.Text);
            entity.UOMPrice =Convert.ToDouble(txtUOMPrice.Text);
            entity.PackQty = Convert.ToInt32(txtQty.Text);
            entity.PackPrice = Convert.ToDouble(txtPackPrice.Text);
            entity.PurchaseDate = Convert.ToDateTime(dtpPurchaseDate.Text);
            entity.SupplierCD = cboSupplier.SelectedValue.ToString();
            entity.PackTypeCode = cboPackType.SelectedValue.ToString();
            return entity;
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
            int rowId = dgvPurchaseItem.Rows.Add();
            DataGridViewRow row = dgvPurchaseItem.Rows[rowId];
            dgvPurchaseItem.Rows[rowId].Cells["ItemCD"].Value = cboItemName.SelectedValue;
            dgvPurchaseItem.Rows[rowId].Cells["PackTypeCode"].Value = cboPackType.SelectedValue;
            dgvPurchaseItem.Rows[rowId].Cells["ItemName"].Value = cboItemName.Text;
            dgvPurchaseItem.Rows[rowId].Cells["PackTypeName"].Value = cboPackType.Text;
            dgvPurchaseItem.Rows[rowId].Cells["QtyPerPack"].Value = txtQtyPerPack.Text;
            dgvPurchaseItem.Rows[rowId].Cells["PackPrice"].Value = txtPackPrice.Text;
            dgvPurchaseItem.Rows[rowId].Cells["UOMPrice"].Value = txtUOMPrice.Text;
            dgvPurchaseItem.Rows[rowId].Cells["Qty"].Value = txtQty.Text;
            CleardData();
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

        private void txtPackPrice_Enter(object sender, EventArgs e)
        {
            string val = txtPackPrice.Text;
            if (!string.IsNullOrEmpty(txtPackPrice.Text))
            {
                txtUOMPrice.Text = Math.Ceiling(Convert.ToDouble(Convert.ToInt32(txtPackPrice.Text) / Convert.ToInt32(txtQtyPerPack.Text))).ToString();
            }
        }
    }
}
