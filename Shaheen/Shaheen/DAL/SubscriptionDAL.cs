using Shaheen.Models;
using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;

namespace Shaheen.DAL
{
    public class SubscriptionDAL : BaseDAL
    {
        public SubscriptionDAL()
        {
            
        }
        public int SaveSubscription(Subscription subscription)
        {
            context.Subscriptions.Add(subscription);
            context.SaveChanges();
            return subscription.subscriptionId;
        }
        public List<Subscription> GetDuplicateSubscriptionCode(int subscriptionId, string subscriptionCode)
        {
            return context.Subscriptions.Where(w => w.subscriptionCode == subscriptionCode && w.subscriptionId != subscriptionId).ToList();
        }

        public List<SubscriptionModel> SubscriptionListWhole()
        {
            DataTable dt = new DataTable();
            string strQuery = @"Select P.personId, p.personName,
                SUB.subscriptionId, SUB.subscriptionCode,SUB.subscriptionDate,SUB.pendingAmount,
                SUBD.subscriptionDetailId,SUBD.subscriptionStartDate, SUBD.subscriptionEndDate,
                A.AreaName, C.cityName,D.districtName, S.stateName, AG.agentName
                from Person P
                INNER JOIN Subscription SUB ON P.personId = SUB.personId
                INNER JOIN SubscriptionDetail SUBD ON SUB.subscriptionId = SUBD.subscriptionId
                LEFT OUTER JOIN Area A ON P.areaId = A.areaId
                LEFT OUTER JOIN City C ON P.cityId = C.cityId
                LEFT OUTER JOIN District D ON P.districtId = D.districtId
                LEFT OUTER JOIN State S ON P.stateId = S.stateId
                LEFT OUTER JOIN Agent AG ON SUB.agentId = AG.agentId
                Where SUBD.status = 1
                Order by PersonId asc";
            var list = new List<SubscriptionModel>();
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(strQuery, con);
                cmd.CommandType = CommandType.Text;
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        list.Add(new SubscriptionModel()
                        {
                            personId = Convert.ToInt32(dr["personId"]),
                            personName = Convert.ToString(dr["personName"]),
                            subscriptionId = Convert.ToInt32(dr["subscriptionId"]),
                            subscriptionCode = Convert.ToString(dr["subscriptionCode"]),
                            subscriptionDate = Convert.ToDateTime(dr["subscriptionDate"]),
                            pendingAmount = Convert.ToDecimal(dr["pendingAmount"]),
                            subscriptionDetailId = Convert.ToInt32(dr["subscriptionDetailId"]),
                            subscriptionStartDate = Convert.ToDateTime(dr["subscriptionStartDate"]),
                            subscriptionEndDate = Convert.ToDateTime(dr["subscriptionEndDate"]),
                            AreaName = Convert.ToString(dr["areaName"]),
                            cityName = Convert.ToString(dr["cityName"]),
                            districtName = Convert.ToString(dr["districtName"]),
                            stateName = Convert.ToString(dr["stateName"]),
                            agentName = Convert.ToString(dr["agentName"])
                        });
                    }
                }
            }

            return list;

            //list = context.People.Join(context.Subscriptions, p => p.personId, sub => sub.personId, (p, sub) => new { p, sub })
            //    .Join(context.SubscriptionDetails, sub => sub.sub.subscriptionId, subd => subd.subscriptionId, (sub, subd) => new { sub, subd })
            //    .Join(context.Areas, p => p.sub.p.areaId, a => a.areaId, (p, a) => new { p, a })
            //    .Join(context.Cities, p => p.p.sub.p.cityId, ct => ct.cityId, (p, ct) => new { p, ct })
            //    .Join(context.Districts, p => p.p.p.sub.p.districtId, dist => dist.districtId, (p, dist) => new { p, dist })
            //    .Join(context.States, p => p.p.p.p.sub.p.stateId, st => st.stateId, (p, st) => new { p, st })
            //    .Join(context.Agents, p => p.p.p.p.p.sub.sub.agentId, ag => ag.agentId, (p, ag) => new { p, ag })
            //    .Select(m => new SubscriptionModel
            //    {
            //        personId = m.p.p.p.p.p.sub.p.personId,
            //        personName = m.p.p.p.p.p.sub.p.personName,
            //        subscriptionId = m.p.p.p.p.p.sub.sub.subscriptionId,
            //        subscriptionCode = m.p.p.p.p.p.sub.sub.subscriptionCode,
            //        subscriptionDate = m.p.p.p.p.p.sub.sub.subscriptionDate,
            //        pendingAmount = m.p.p.p.p.p.sub.sub.pendingAmount,
            //        subscriptionDetailId = m.p.p.p.p.p.subd.subscriptionDetailId,
            //        subscriptionStartDate = m.p.p.p.p.p.subd.subscriptionStartDate,
            //        subscriptionEndDate = m.p.p.p.p.p.subd.subscriptionEndDate,
            //        AreaName = m.p.p.p.p.a.areaName,
            //        cityName = m.p.p.p.ct.cityName,
            //        districtName = m.p.p.dist.districtName,
            //        stateName = m.p.st.stateName,
            //        agentName = m.ag.agentName

            //    }).ToList();
        }
    }
}
