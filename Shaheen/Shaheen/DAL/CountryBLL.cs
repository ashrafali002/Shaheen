using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.DAL
{
    public class CountryDAL
    {
        ShaheenEntities context = null;
        public CountryDAL()
        {
            context = new ShaheenEntities();
        }
        public List<Country> CountryList()
        {
            return context.Countries.ToList();
        }
    }
}
