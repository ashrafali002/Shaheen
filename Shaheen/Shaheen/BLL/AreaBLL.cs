using Shaheen.DAL;
using Shaheen.IshraqEntities;
using Shaheen.Models;
using System.Collections.Generic;
using System.Linq;

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

        public int SaveArea(Area area)
        {
            return areaDal.SaveArea(area);
        }

        public Area GetAreaById(int Id)
        {
            return areaDal.GetAreaById(Id);
        }
        public Area GetAreaByName(string areaName)
        {
            return areaDal.GetAreaByName(areaName);
        }
        public bool IsDuplicateAreaName(int areaId, string areaName)
        {
            var isDuplicateFound = true;
            var duplicateList = areaDal.GetDuplicateAreaName(areaId, areaName);
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

        public void DeleteArea(int areaId)
        {
            areaDal.DeleteArea(areaId);

        }
    }
}
