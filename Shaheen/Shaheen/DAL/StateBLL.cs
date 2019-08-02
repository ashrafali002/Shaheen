using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.DAL
{
    public class StateDAL
    {
        ShaheenEntities context = null;
        public StateDAL()
        {
            context = new ShaheenEntities();
        }
        public List<State> StateList()
        {
            return context.States.ToList();
        }
    }
}
