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
        ShaheenEntities context = null;
        public CountryBLL()
        {
            context = new ShaheenEntities();
        }
        public List<Country> CountryList()
        {
            return context.Countries.ToList();
        }
    }
}
