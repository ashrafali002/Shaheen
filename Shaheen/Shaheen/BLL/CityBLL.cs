using Shaheen.DAL;
using Shaheen.Models;
using Shaheen.ShaheenDB;
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

        public List<CityDistrict> CityDistrictList()
        {
            return cityDal.CityDistrictList();
        }

        public int SaveCity(City state)
        {
            return cityDal.SaveCity(state);
        }

        public City GetCityById(int Id)
        {
            return cityDal.GetCityById(Id);
        }
        public City GetCityByName(string stateName)
        {
            return cityDal.GetCityByName(stateName);
        }
        public bool IsDuplicateCityName(int stateId, string stateName)
        {
            var isDuplicateFound = true;
            var duplicateList = cityDal.GetDuplicateCityName(stateId, stateName);
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

        public void DeleteCity(int districtId)
        {
            cityDal.DeleteCity(districtId);

        }
    }
}
