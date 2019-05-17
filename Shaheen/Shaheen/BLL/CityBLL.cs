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
        ShaheenEntities context = null;
        public CityBLL()
        {
            context = new ShaheenEntities();
        }
        public List<City> CityList()
        {
            return context.Cities.ToList();
        }
    }
}
