using Shaheen.DAL;
using Shaheen.ShaheenDB;
using System.Collections.Generic;
using System.Linq;

namespace Shaheen.BLL
{
    public class CountryBLL
    {
        public CountryDAL countryDal;
        public CountryBLL()
        {
            countryDal = new CountryDAL();
        }
        public List<Country> CountryList()
        {
            var list = countryDal.CountryList();
            return list;
        }

        public int SaveCountry(Country country)
        {
            return countryDal.SaveCountry(country);
        }

        public Country GetCountryById(int Id)
        {
            return countryDal.GetCountryById(Id);
        }
        public Country GetCountryByName(string countryName)
        {
            return countryDal.GetCountryByName(countryName);
        }
        public bool IsDuplicateCountryName(int countryId, string countryName)
        {
            var isDuplicateFound = true;
            var duplicateList = countryDal.GetDuplicateCountryName(countryId, countryName);
            if (duplicateList.Count() == 0)
            {
                isDuplicateFound = false;
            }
            else
            {
                isDuplicateFound = true;
            }
            return isDuplicateFound;
        }

        public void DeleteCountry(int countryId)
        {
            countryDal.DeleteCountry(countryId);
        }


    }
}
