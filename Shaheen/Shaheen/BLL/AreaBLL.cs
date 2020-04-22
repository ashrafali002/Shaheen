using Shaheen.DAL;
using Shaheen.Models;
using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.BLL
{
    public class AreaBLL
    {
        public AreaDAL cityDal;
        public AreaBLL()
        {
            cityDal = new AreaDAL();
        }
        public List<Area> AreaList()
        {
            var list = cityDal.AreaList();
            return list;
        }

        public List<AreaCity> AreaCityList()
        {
            return cityDal.AreaCityList();
        }

        public int SaveArea(Area state)
        {
            return cityDal.SaveArea(state);
        }

        public Area GetAreaById(int Id)
        {
            return cityDal.GetAreaById(Id);
        }
        public Area GetAreaByName(string stateName)
        {
            return cityDal.GetAreaByName(stateName);
        }
        public bool IsDuplicateAreaName(int stateId, string stateName)
        {
            var isDuplicateFound = true;
            var duplicateList = cityDal.GetDuplicateAreaName(stateId, stateName);
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

        public void DeleteArea(int districtId)
        {
            cityDal.DeleteArea(districtId);

        }
    }
}
