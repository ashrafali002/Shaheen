using Shaheen.DAL;
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
        public AgentDAL agentDal;
        public AgentBLL()
        {
            agentDal = new AgentDAL();
        }

        public List<Agent> AgentList()
        {
            var list = agentDal.AgentList();
            return list;
        }
    }
}
