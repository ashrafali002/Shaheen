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
            dr["Username"] = "admin";
            dr["Password"] = "admin";
            dr["Type"] = 0;
            dt.Rows.Add(dr);


            DataRow dr2 = dt.NewRow();
            dr2["Username"] = "shaheen";
            dr2["Password"] = "Akhan#";
            dr["Type"] = 1;
            dt.Rows.Add(dr2);

            return dt;
        }
    }
}
