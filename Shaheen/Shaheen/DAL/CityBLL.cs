using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.DAL
{
    public class CityDAL
    {
        ShaheenEntities context = null;
        public CityDAL()
        {
            context = new ShaheenEntities();
        }
        public List<City> CityList()
        {
            return context.Cities.ToList();
        }
    }
}
