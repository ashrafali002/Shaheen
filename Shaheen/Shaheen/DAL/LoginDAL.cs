using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.DAL
{
    public class LoginDAL
    {
        public DataTable LoginTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn { ColumnName = "Username", DataType = typeof(string) });
            dt.Columns.Add(new DataColumn { ColumnName = "Password", DataType = typeof(string) });
            //dt.Columns.Add("Username", typeof(string));
            //dt.Columns.Add("Password", typeof(string));

            DataRow dr = dt.NewRow();
            dr["Username"] = "admin";
            dr["Password"] = "admin";
            dt.Rows.Add(dr);


            DataRow dr2 = dt.NewRow();
            dr2["Username"] = "ashraf";
            dr2["Password"] = "ashraf";
            dt.Rows.Add(dr2);

            return dt;
        }
    }
}
