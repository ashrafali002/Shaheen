using Shaheen.IshtiraqEntities;
using Shaheen.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shaheen.DAL
{
    public class StateDAL : BaseDAL
    {
        protected IshtiraqContext context;
        public StateDAL()
        {
            context = new IshtiraqContext();
        }
        public List<State> StateList()
        {
            return context.States.OrderBy(o => o.stateName).ToList();
        }

        public List<State> StateByCountryId(int countryId)
        {
            return context.States.Where(w => w.countryId == countryId).OrderBy(o => o.stateName).ToList();
        }
        public List<StateCountry> StateCountryList()
        {
            var list = new List<StateCountry>();
            list = context.States.Join(context.Countries, s => s.countryId, c => c.countryId, (s, c) => new StateCountry()
            {
                stateId = s.stateId,
                stateName = s.stateName,
                countryId = s.countryId,
                countryName = c.countryName
            }).OrderBy(o => o.stateId).ToList();
            return list;
        }
        public int SaveState(State state)
        {
            if (state.stateId == 0)
            {
                context.States.Add(state);
            }
            else
            {
                State c = context.States.Find(state.stateId);
                c.stateName = state.stateName;
                c.countryId = state.countryId;
                context.Entry(c).State = System.Data.Entity.EntityState.Modified;
            }

            context.SaveChanges();
            return state.stateId;
        }

        public State GetStateById(int Id)
        {
            return context.States.Where(w => w.stateId == Id).FirstOrDefault();
        }
        public State GetStateByName(string stateName)
        {
            return context.States.Where(w => w.stateName == stateName).FirstOrDefault();
        }

        public List<State> GetDuplicateStateName(int stateId, string stateName)
        {
            return context.States.Where(w => w.stateName == stateName && w.stateId != stateId).ToList();
        }

        public void DeleteState(int stateId)
        {
            var c = context.States.Find(stateId);
            context.States.Remove(c);
            context.SaveChanges();
        }
    }
}
