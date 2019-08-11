using Shaheen.ShaheenDB;
using System.Collections.Generic;
using System.Linq;

namespace Shaheen.DAL
{
    public class StateDAL : BaseDAL
    {
        public StateDAL()
        {
        }
        public List<State> StateList()
        {
            return context.States.ToList();
        }
    }
}
