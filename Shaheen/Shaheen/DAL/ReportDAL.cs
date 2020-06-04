using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.DAL
{
    public class ReportDAL : BaseDAL
    {
        public DataTable GetAgentWiseStatusCount()
        {
            DataTable dt = new DataTable();
            string strQuery = @"Select S.agentId, A.agentName,
                    count(*) totalCount,
                    sum(case when status = 1 then 1 else 0 end) activeCount,
                    sum(case when status = 2 then 1 else 0 end) closeCount,
                    sum(case when status = 3 then 1 else 0 end) continueCount
                    from Subscription S INNER JOIN Agent A ON S.agentId = A.agentId 
                    Group By S.agentId, A.agentName";
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(strQuery, con);
                cmd.CommandType = CommandType.Text;
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetStatusWiseCount()
        {
            DataTable dt = new DataTable();
            string strQuery = @"Select status,count(*) totalCount from Subscription Group By status";
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(strQuery, con);
                cmd.CommandType = CommandType.Text;
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
