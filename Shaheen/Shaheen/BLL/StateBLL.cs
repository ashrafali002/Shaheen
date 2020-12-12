using Shaheen.DAL;
using Shaheen.IshtiraqEntities;
using Shaheen.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shaheen.BLL
{
    public class StateBLL
    {
        public StateDAL stateDal;
        public StateBLL()
        {
            stateDal = new StateDAL();
        }
        public List<State> StateList()
        {
            var list = stateDal.StateList();
            return list;
        }

        public List<State> StateByCountryId(int countryId)
        {
            return stateDal.StateByCountryId(countryId);
        }

        public List<StateCountry> StateCountryList()
        {
            return stateDal.StateCountryList();
        }

        public int SaveState(State state)
        {
            return stateDal.SaveState(state);
        }

        public State GetStateById(int Id)
        {
            return stateDal.GetStateById(Id);
        }
        public State GetStateByName(string stateName)
        {
            return stateDal.GetStateByName(stateName);
        }
        public bool IsDuplicateStateName(int stateId, string stateName)
        {
            var isDuplicateFound = true;
            var duplicateList = stateDal.GetDuplicateStateName(stateId, stateName);
            if (duplicateList.Count() == 0)
            {
                isDuplicateFound = false;
            }
            else
            {
                isDuplicateFound = true;
            }
            return isDuplicateFound;
        }

        public void DeleteState(int stateId)
        {
            stateDal.DeleteState(stateId);
        }
    }
}
