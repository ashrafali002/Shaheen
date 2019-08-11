using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
