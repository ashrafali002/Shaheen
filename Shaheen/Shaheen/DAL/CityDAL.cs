using Shaheen.Models;
using Shaheen.ShaheenDB;
using System.Collections.Generic;
using System.Linq;

namespace Shaheen.DAL
{
    public class CityDAL : BaseDAL
    {
        protected ShaheenEntities context;
        public CityDAL()
        {
            context = new ShaheenEntities();
        }
        public List<City> CityList()
        {
            return context.Cities.OrderBy(o => o.cityName).ToList();
        }

        public List<CityDistrict> CityDistrictList()
        {
            var list = new List<CityDistrict>();
            list = context.Cities.Join(context.Districts, s => s.districtId, c => c.districtId, (s, c) => new CityDistrict()
            {
                cityId = s.cityId,
                cityName = s.cityName,
                districtId = s.districtId,
                districtName = c.districtName
            }).OrderBy(o => o.cityId).ToList();
            return list;
        }
        public int SaveCity(City city)
        {
            if (city.cityId == 0)
            {
                context.Cities.Add(city);
            }
            else
            {
                City c = context.Cities.Find(city.cityId);
                c.cityName = city.cityName;
                c.districtId = city.districtId;
                context.Entry(c).State = System.Data.Entity.EntityState.Modified;
            }

            context.SaveChanges();
            return city.cityId;
        }

        public City GetCityById(int Id)
        {
            return context.Cities.Where(w => w.cityId == Id).FirstOrDefault();
        }
        public City GetCityByName(string cityName)
        {
            return context.Cities.Where(w => w.cityName == cityName).FirstOrDefault();
        }

        public List<City> GetDuplicateCityName(int cityId, string cityName)
        {
            return context.Cities.Where(w => w.cityName == cityName && w.cityId != cityId).ToList();
        }

        public void DeleteCity(int cityId)
        {
            var c = context.Cities.Find(cityId);
            context.Cities.Remove(c);
            context.SaveChanges();
        }
    }
}
