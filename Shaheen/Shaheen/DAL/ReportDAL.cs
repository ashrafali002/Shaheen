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
        /// <summary>
        /// Get datatable for Address label printing
        /// </summary>
        /// <returns>Datatable</returns>
        public DataTable GetPersonForLablePrint()
        {
            DataTable dt = new DataTable();
            DateTime todayDate = DateTime.Now;
            string strQuery = @"Select P.personId,P.personName,P.personAddress,P.areaId,A.areaName,P.cityId,CT.cityName,
                P.districtId,D.districtName,P.stateId,S.stateName,P.countryId,C.countryName,P.pin,P.phone,P.mobile,P.email,
                SUB.subscriptionCode, SUBD.subscriptionEndDate
                From Person P 
                INNER JOIN Subscription SUB ON P.personId = SUB.personId
                INNER JOIN SubscriptionDetail SUBD ON SUB.subscriptionId = SUBD.subscriptionId
                LEFT OUTER JOIN Country C ON P.countryId = C.countryId
                LEFT OUTER JOIN State S ON P.stateId = S.stateId
                LEFT OUTER JOIN District D ON P.districtId = D.districtId
                LEFT OUTER JOIN City CT ON P.cityId = CT.cityId
                LEFT OUTER JOIN Area A ON P.areaId = A.areaId
                Where SUB.status in (1,3)                     
                    AND SUBD.status = 1 
                    AND SUBD.subscriptionEndDate >= '" + todayDate.ToLongDateString() + " 23:59:59' Order by subscriptionType asc";
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

        public DataTable GetCustomizedPersonList(string whereCondition)
        {
            DataTable dt = new DataTable();
            string strQuery = @"Select P.personId,P.personName,P.areaId,A.areaName,P.cityId,CT.cityName,
                P.districtId,D.districtName,P.stateId,S.stateName,P.countryId,C.countryName,P.pin,P.phone,P.mobile,P.email,
                SUB.subscriptionCode, SUB.pendingAmount, SUB.status,AG.agentName,
                COALESCE(P.personAddress,'')+', '+COALESCE(A.areaName,'')+', '+COALESCE(CT.cityName,'')+', '+COALESCE(D.districtName,'')+', '+COALESCE(S.stateName,'') AS personAddress,
                SUBD.subscriptionEndDate
                From Person P 
                INNER JOIN Subscription SUB ON P.personId = SUB.personId
                INNER JOIN SubscriptionDetail SUBD ON SUB.subscriptionId = SUBD.subscriptionId
                LEFT OUTER JOIN Country C ON P.countryId = C.countryId
                LEFT OUTER JOIN State S ON P.stateId = S.stateId
                LEFT OUTER JOIN District D ON P.districtId = D.districtId
                LEFT OUTER JOIN City CT ON P.cityId = CT.cityId
                LEFT OUTER JOIN Area A ON P.areaId = A.areaId
                LEFT OUTER JOIN Agent AG ON SUB.agentId = AG.agentId
                Where SUBD.status = 1 ";
            strQuery += whereCondition;
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
