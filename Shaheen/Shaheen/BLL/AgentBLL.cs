using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.BLL
{
    public class AgentBLL
    {
        static ShaheenEntities context = null;
        public AgentBLL()
        {
            context = new ShaheenEntities();
        }
        public List<AgentModel> AgentList()
        {
            var agentList = context.Agents.Join(context.People, a => a.personId, p => p.personId, (a, p) => new
            AgentModel()
            {
                agentId = a.agentId,
                agentCode = a.agentCode,
                personId = a.personId,
                agentName = p.personName
            });

            return agentList.ToList();
        }
    }
}
