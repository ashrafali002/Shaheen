using Shaheen.DAL;
using Shaheen.IshtiraqEntities;
using Shaheen.Models;
using System.Collections.Generic;

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

        public List<AgentModel> AgentFullList()
        {
            return agentDal.AgentFullList();
        }

        public int SaveAgent(Agent agent)
        {
            return agentDal.SaveAgent(agent);
        }

        public Agent GetAgentById(int Id)
        {
            return agentDal.GetAgetById(Id);
        }

        public void DeleteAgent(int agentId)
        {
            agentDal.DeleteAgent(agentId);
        }
    }
}
