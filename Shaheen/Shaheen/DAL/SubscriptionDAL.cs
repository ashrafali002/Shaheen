using Shaheen.IshraqEntities;
using Shaheen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlServerCe;
using System.Linq;

namespace Shaheen.DAL
{
    public class SubscriptionDAL : BaseDAL
    {
        private readonly IshraqContext context;
        public SubscriptionDAL()
        {
            context = new IshraqContext();
        }
        public SubscriptionModel GetSubscriptionWholeByCode(string code)
        {
            return SubscriptionListWhole(string.Empty).Where(w => w.subscriptionCode == code).FirstOrDefault();
        }
        public Subscription GetSubscriptionById(int Id)
        {
            return context.Subscriptions.Where(w => w.subscriptionId == Id).FirstOrDefault();
        }
        public List<Subscription> GetDuplicateSubscriptionCode(int subscriptionId, string subscriptionCode)
        {
            return context.Subscriptions.Where(w => w.subscriptionCode == subscriptionCode && w.subscriptionId != subscriptionId).ToList();
        }

        public int SaveSubscription(Subscription subscription)
        {
            if (subscription.subscriptionId == 0)
            {
                context.Subscriptions.Add(subscription);
            }
            else
            {
                Subscription s = context.Subscriptions.Find(subscription.subscriptionId);
                s.subscriptionCode = subscription.subscriptionCode;
                s.personId = subscription.personId;
                s.agentId = subscription.agentId;
                s.pendingAmount = subscription.pendingAmount;
                s.subscriptionDate = subscription.subscriptionDate;
                s.status = subscription.status;
                context.Entry(s).State = EntityState.Modified;
            }
            context.SaveChanges();
            return subscription.subscriptionId;
        }

        public List<SubscriptionModel> SubscriptionListWhole(string searchString)
        {
            DataTable dt = new DataTable();
            string strQuery = @"Select P.personId, p.personName,
                SUB.subscriptionId, SUB.subscriptionCode,SUB.subscriptionDate,SUB.pendingAmount,SUB.status,
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
                Where SUBD.status = 1 ";
            if (!string.IsNullOrEmpty(searchString))
            {
                strQuery += searchString;
            }
            strQuery += "Order by PersonId asc";

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
                            agentName = Convert.ToString(dr["agentName"]),
                            status = Convert.ToInt32(dr["status"])
                        });
                    }
                }
            }
            return list;
        }
    }
}
