using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.BLL
{
    public class DistrictBLL
    {
        static ShaheenEntities entities = new ShaheenEntities();
        public static List<District> DistrictList()
        {
            return entities.Districts.ToList();
        }
    }
}
