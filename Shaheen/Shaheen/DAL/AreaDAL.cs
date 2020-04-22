using Shaheen.Models;
using Shaheen.ShaheenDB;
using System.Collections.Generic;
using System.Linq;

namespace Shaheen.DAL
{
    public class AreaDAL : BaseDAL
    {
        public AreaDAL()
        {
        }
        public List<Area> AreaList()
        {
            return context.Areas.OrderBy(o => o.areaName).ToList();
        }

        public List<AreaCity> AreaCityList()
        {
            var list = new List<AreaCity>();
            list = context.Areas.Join(context.Cities, s => s.cityId, c => c.cityId, (s, c) => new AreaCity()
            {
                areaId = s.areaId,
                areaName = s.areaName,
                cityId = s.cityId,
                cityName = c.cityName
            }).OrderBy(o => o.areaId).ToList();
            return list;
        }
        public int SaveArea(Area area)
        {
            if (area.areaId == 0)
            {
                context.Areas.Add(area);
            }
            else
            {
                Area c = context.Areas.Find(area.areaId);
                c.areaName = area.areaName;
                c.cityId = area.cityId;
                context.Entry(c).State = System.Data.Entity.EntityState.Modified;
            }

            context.SaveChanges();
            return area.areaId;
        }

        public Area GetAreaById(int Id)
        {
            return context.Areas.Where(w => w.areaId == Id).FirstOrDefault();
        }
        public Area GetAreaByName(string areaName)
        {
            return context.Areas.Where(w => w.areaName == areaName).FirstOrDefault();
        }

        public List<Area> GetDuplicateAreaName(int areaId, string areaName)
        {
            return context.Areas.Where(w => w.areaName == areaName && w.areaId != areaId).ToList();
        }

        public void DeleteArea(int areaId)
        {
            var c = context.Areas.Find(areaId);
            context.Areas.Remove(c);
            context.SaveChanges();
        }
    }
}
