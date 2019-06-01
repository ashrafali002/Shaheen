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
        public List<Agent> AgentList()
        {
            return context.Agents.ToList();
        }
    }
}
