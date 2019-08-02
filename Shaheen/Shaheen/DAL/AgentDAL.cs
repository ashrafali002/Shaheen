using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.DAL
{
    public class AgentDAL
    {
        static ShaheenEntities context = null;
        public AgentDAL()
        {
            context = new ShaheenEntities();
        }
        public List<Agent> AgentList()
        {
            return context.Agents.ToList();
        }
    }
}
