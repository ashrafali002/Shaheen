using Shaheen.ShaheenDB;
using System.Collections.Generic;
using System.Linq;

namespace Shaheen.DAL
{
    public class AgentDAL : BaseDAL
    {
        public AgentDAL()
        {
        }
        public List<Agent> AgentList()
        {
            return context.Agents.ToList();
        }
    }
}
