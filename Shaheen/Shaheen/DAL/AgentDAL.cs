using Shaheen.IshtiraqEntities;
using Shaheen.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shaheen.DAL
{
    public class AgentDAL : BaseDAL
    {
        protected IshtiraqContext context;
        public AgentDAL()
        {
            context = new IshtiraqContext();
        }
        public List<Agent> AgentList()
        {
            return context.Agents.OrderBy(o => o.agentId).ToList();
        }

        public List<AgentModel> AgentFullList()
        {
            var list = new List<AgentModel>();
            list = context.Agents.Join(context.Countries, ag => ag.countryId, cn => cn.countryId, (ag, cn) => new { ag, cn })
                .Join(context.States, ag => ag.ag.stateId, st => st.stateId, (ag, st) => new { ag, st })
                .Join(context.Districts, ag => ag.ag.ag.districtId, dt => dt.districtId, (ag, dt) => new { ag, dt })
                .Join(context.Cities, ag => ag.ag.ag.ag.cityId, ct => ct.cityId, (ag, ct) => new { ag, ct })
                .Join(context.Areas, ag => ag.ag.ag.ag.ag.areaId, aa => aa.areaId, (ag, aa) => new { ag, aa })
                .Select(m => new AgentModel
                {
                    agentId = m.ag.ag.ag.ag.ag.agentId,
                    agentName = m.ag.ag.ag.ag.ag.agentName,
                    agentAddress = m.ag.ag.ag.ag.ag.agentAddress,
                    areaId = m.ag.ag.ag.ag.ag.areaId,
                    areaName = m.aa.areaName,
                    cityId = m.ag.ag.ag.ag.ag.cityId,
                    cityName = m.ag.ct.cityName,
                    districtId = m.ag.ag.ag.ag.ag.districtId,
                    districtName = m.ag.ag.dt.districtName,
                    stateId = m.ag.ag.ag.ag.ag.stateId,
                    stateName = m.ag.ag.ag.st.stateName,
                    countryId = m.ag.ag.ag.ag.ag.countryId,
                    countryName = m.ag.ag.ag.ag.cn.countryName,
                    pin = m.ag.ag.ag.ag.ag.pin,
                    phone = m.ag.ag.ag.ag.ag.phone,
                    mobile = m.ag.ag.ag.ag.ag.mobile,
                    email = m.ag.ag.ag.ag.ag.email
                }).ToList();
            return list;
        }

        public int SaveAgent(Agent agent)
        {
            if (agent.agentId == 0)
            {
                context.Agents.Add(agent);
            }
            else
            {
                Agent a = context.Agents.Find(agent.agentId);
                a.agentName = agent.agentName;
                a.agentAddress = agent.agentAddress;
                a.areaId = agent.areaId;
                a.cityId = agent.cityId;
                a.districtId = agent.districtId;
                a.stateId = agent.stateId;
                a.countryId = agent.countryId;
                a.pin = agent.pin;
                a.phone = agent.phone;
                a.mobile = agent.mobile;
                a.email = agent.email;
                context.Entry(a).State = System.Data.Entity.EntityState.Modified;
            }

            context.SaveChanges();
            return agent.agentId;
        }

        public Agent GetAgetById(int Id)
        {
            return context.Agents.Where(w => w.agentId == Id).FirstOrDefault();
        }

        public void DeleteAgent(int agentId)
        {
            var a = context.Agents.Find(agentId);
            context.Agents.Remove(a);
            context.SaveChanges();
        }
    }
}
