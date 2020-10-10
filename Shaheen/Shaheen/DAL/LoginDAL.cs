using System.Data;

namespace Shaheen.DAL
{
    public class LoginDAL
    {
        public DataTable LoginTable()
        {
            //Type of User
            // User = 0
            // Admin = 1
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn { ColumnName = "Username", DataType = typeof(string) });
            dt.Columns.Add(new DataColumn { ColumnName = "Password", DataType = typeof(string) });
            dt.Columns.Add(new DataColumn { ColumnName = "Type", DataType = typeof(int) });

            DataRow dr = dt.NewRow();
            dr["Username"] = "shaheen";
            dr["Password"] = "shaheen123";
            dr["Type"] = 3;
            dt.Rows.Add(dr);


            DataRow dr2 = dt.NewRow();
            dr2["Username"] = "shaheen";
            dr2["Password"] = "Akhan#123";
            dr2["Type"] = 2;
            dt.Rows.Add(dr2);

            DataRow dr3 = dt.NewRow();
            dr3["Username"] = "sadmin";
            dr3["Password"] = "Shaheen_002";
            dr3["Type"] = 1;
            dt.Rows.Add(dr3);

            return dt;
        }
    }
}
