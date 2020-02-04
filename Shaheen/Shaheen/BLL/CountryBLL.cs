using Shaheen.DAL;
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
        public List<Country> CountryList()
        {
            var countryDAL = new CountryDAL();
            var list = countryDAL.CountryList();
            return list;
        }

        
    }
}
