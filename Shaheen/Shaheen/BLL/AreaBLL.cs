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
        public AreaDAL areaDal;
        public AreaBLL()
        {
            areaDal = new AreaDAL();
        }
        public List<Area> AreaList()
        {
            var list = areaDal.AreaList();
            return list;
        }

        public List<AreaCity> AreaCityList()
        {
            return areaDal.AreaCityList();
        }

        public int SaveArea(Area state)
        {
            return areaDal.SaveArea(state);
        }

        public Area GetAreaById(int Id)
        {
            return areaDal.GetAreaById(Id);
        }
        public Area GetAreaByName(string stateName)
        {
            return areaDal.GetAreaByName(stateName);
        }
        public bool IsDuplicateAreaName(int stateId, string stateName)
        {
            var isDuplicateFound = true;
            var duplicateList = areaDal.GetDuplicateAreaName(stateId, stateName);
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
            areaDal.DeleteArea(districtId);

        }
    }
}
