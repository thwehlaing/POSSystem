using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class BaseEntity
    {
        public string SPName { get; set; }
        public SqlParameter[] Sqlprms { get; set; }
        public string LoginDate { get; set; }
        public string PC { get; set; }
        public string MessageID { get; set; }

        public string OperatorCD { get; set; }
        public string ProgramID { get; set; }
        public string InsertOperator { get; set; }
        public string UpdateOperator { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
