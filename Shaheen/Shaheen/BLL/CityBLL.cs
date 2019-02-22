using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.BLL
{
    public class CityBLL
    {
        static ShaheenEntities entities = null;
        public CityBLL()
        {
            entities = new ShaheenEntities();
        }
        public static List<City> CityList()
        {
            return entities.Cities.ToList();
        }
    }
}
