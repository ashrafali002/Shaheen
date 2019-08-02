using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.DAL
{
    public class AreaDAL
    {
        ShaheenEntities context = null;
        public AreaDAL()
        {
            context = new ShaheenEntities();
        }
        public List<Area> AreaList()
        {
            return context.Areas.ToList();
        }
    }
}
