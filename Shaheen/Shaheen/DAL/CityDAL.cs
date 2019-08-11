using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
