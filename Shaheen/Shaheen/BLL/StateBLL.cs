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
        static ShaheenEntities entities = null;
        public StateBLL()
        {
            entities = new ShaheenEntities();
        }
        public static List<State> StateList()
        {
            return entities.States.ToList();
        }
    }
}
