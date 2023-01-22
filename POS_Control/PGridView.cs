using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace POS_Control
{
    public class PGridView:DataGridView
    {
        bool UseRow = true;
        bool EditCol = false;

        bool AllReadonly = false;
        bool ForSearchForm = false;
        string NumberCol = string.Empty;
        public void SetGridDesign()
        {
            this.EnableHeadersVisualStyles = false;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(191, 191, 191);
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Myanmar Text", 9, FontStyle.Bold);           
        }
        public void UseRowNo(bool val)
        {
            UseRow = RowHeadersVisible = val;
        }
        public void SetReadOnlyColumn(string colArr)
        {
            foreach (DataGridViewColumn col in Columns)
            {
                if (colArr.Equals("*"))
                {
                    SetReadOnly(col);
                    AllReadonly = true;
                }
                else if (colArr.Equals("**"))
                {
                    SetReadOnly(col);
                    ForSearchForm = true;
                }
                else
                {
                    string[] arr = colArr.Split(',');
                    ArrayList arrlst = new ArrayList();
                    arrlst.AddRange(arr);

                    if (arrlst.Contains(col.Name))
                    {
                        SetReadOnly(col);
                    }
                }
            }
        }

        private void SetReadOnly(DataGridViewColumn col)
        {
            col.ReadOnly = true;
            col.DefaultCellStyle.BackColor = Color.FromArgb(217, 217, 217);
        }
        public void SetNumberColumn(string colArr)
        {
            NumberCol = colArr;
        }

        public bool IsErrorOccurs { get; set; }
        public string ISRowColumn { get; set; }

        public bool ErrorCheck([Optional] string ChangeDate)
        {
            PGridView svg = this;
            //Creating DataTable.
            DataTable dt = svg.DataSource as DataTable;
            //(IsErrorOccurs, ISRowColumn) = DataTable_ErrorCheck(svg.Memory_Row_Count, dt, svg.Name, ChangeDate);
            //if (IsErrorOccurs)
            //{
            //    if (!string.IsNullOrEmpty(ISRowColumn))
            //    {
            //        svg.CurrentCell = svg.Rows[Convert.ToInt32(ISRowColumn.Split('_')[0])].Cells[Convert.ToInt32(ISRowColumn.Split('_')[1])];
            //        svg.BeginEdit(true);
            //    }
            //}
            return IsErrorOccurs;
        }
    }
}
