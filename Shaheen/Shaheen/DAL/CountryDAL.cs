using Shaheen.IshtiraqEntities;
using System.Collections.Generic;
using System.Linq;

namespace Shaheen.DAL
{
    public class CountryDAL : BaseDAL
    {
        protected IshtiraqContext context;
        public CountryDAL()
        {
            context = new IshtiraqContext();
        }
        public List<Country> CountryList()
        {
            return context.Countries.OrderBy(o => o.countryName).ToList();
        }

        public int SaveCountry(Country country)
        {
            if (country.countryId == 0)
            {
                context.Countries.Add(country);
            }
            else
            {
                Country c = context.Countries.Find(country.countryId);
                c.countryName = country.countryName;
                context.Entry(c).State = System.Data.Entity.EntityState.Modified;
            }

            context.SaveChanges();
            return country.countryId;
        }

        public Country GetCountryById(int Id)
        {
            return context.Countries.Where(w => w.countryId == Id).FirstOrDefault();
        }
        public Country GetCountryByName(string countryName)
        {
            return context.Countries.Where(w => w.countryName == countryName).FirstOrDefault();
        }

        public List<Country> GetDuplicateCountryName(int countryId, string countryName)
        {
            return context.Countries.Where(w => w.countryName == countryName && w.countryId != countryId).ToList();
        }

        public void DeleteCountry(int countryId)
        {
            var c = context.Countries.Find(countryId);
            context.Countries.Remove(c);
            context.SaveChanges();
        }
    }
}
