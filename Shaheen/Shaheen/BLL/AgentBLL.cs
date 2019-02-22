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
        static ShaheenEntities entities = null;
        public AgentBLL()
        {
            entities = new ShaheenEntities();
        }
        public static List<Agent> AgentList()
        {
            return entities.Agents.ToList();
        }
    }
}
