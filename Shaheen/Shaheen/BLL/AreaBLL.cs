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
       static ShaheenEntities entities = new ShaheenEntities();
        public static List<Area> AreaList()
        {
            return entities.Areas.ToList();
        }
    }
}
