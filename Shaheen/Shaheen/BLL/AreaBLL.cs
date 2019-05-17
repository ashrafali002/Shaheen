using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.BLL
{
    public class AreaBLL
    {
        ShaheenEntities context = null;
        public AreaBLL()
        {
            context = new ShaheenEntities();
        }
        public List<Area> AreaList()
        {
            return context.Areas.ToList();
        }
    }
}
