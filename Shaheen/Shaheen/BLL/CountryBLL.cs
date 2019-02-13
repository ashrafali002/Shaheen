using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.BLL
{
    public class CountryBLL
    {
        static ShaheenEntities entities = new ShaheenEntities();
        public static List<Country> CountryList()
        {
            return entities.Countries.ToList();
        }
    }
}
