using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.BLL
{
    public class StateBLL
    {
        ShaheenEntities context = null;
        public StateBLL()
        {
            context = new ShaheenEntities();
        }
        public List<State> StateList()
        {
            return context.States.ToList();
        }
    }
}
