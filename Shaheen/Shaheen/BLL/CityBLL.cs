using Shaheen.DAL;
using Shaheen.IshraqEntities;
using Shaheen.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shaheen.BLL
{
    public class CityBLL
    {
        public CityDAL cityDal;
        public CityBLL()
        {
            cityDal = new CityDAL();
        }
        public List<City> CityList()
        {
            var list = cityDal.CityList();
            return list;
        }

        public List<City> CityByDistrictId(int districtId)
        {
            return cityDal.CityByDistrictId(districtId);
        }

        public List<CityDistrict> CityDistrictList()
        {
            return cityDal.CityDistrictList();
        }

        public int SaveCity(City city)
        {
            return cityDal.SaveCity(city);
        }

        public City GetCityById(int Id)
        {
            return cityDal.GetCityById(Id);
        }
        public City GetCityByName(string cityName)
        {
            return cityDal.GetCityByName(cityName);
        }
        public bool IsDuplicateCityName(int cityId, string cityName)
        {
            var isDuplicateFound = true;
            var duplicateList = cityDal.GetDuplicateCityName(cityId, cityName);
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

        public void DeleteCity(int cityId)
        {
            cityDal.DeleteCity(cityId);
        }
    }
}
