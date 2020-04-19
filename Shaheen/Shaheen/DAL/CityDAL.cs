using Shaheen.ShaheenDB;
using System.Collections.Generic;
using System.Linq;

namespace Shaheen.DAL
{
    public class CityDAL : BaseDAL
    {
        public CityDAL()
        {
        }
        public List<City> CityList()
        {
            return context.Cities.ToList();
        }
    }
}
