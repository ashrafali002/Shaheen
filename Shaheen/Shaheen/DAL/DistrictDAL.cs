using Shaheen.Models;
using Shaheen.ShaheenDB;
using System.Collections.Generic;
using System.Linq;

namespace Shaheen.DAL
{
    public class DistrictDAL : BaseDAL
    {
        public DistrictDAL()
        {
        }
        public List<District> DistrictList()
        {
            return context.Districts.ToList();
        }

        public List<DistrictState> DistrictStateList()
        {
            var list = new List<DistrictState>();
            list = context.Districts.Join(context.States, s => s.stateId, c => c.stateId, (s, c) => new DistrictState()
            {
                districtId = s.districtId,
                districtName = s.districtName,
                stateId = s.stateId,
                stateName = c.stateName
            }).ToList();
            return list;
        }
        public int SaveDistrict(District district)
        {
            if (district.districtId == 0)
            {
                context.Districts.Add(district);
            }
            else
            {
                District c = context.Districts.Find(district.districtId);
                c.districtName = district.districtName;
                c.stateId = district.stateId;
                context.Entry(c).State = System.Data.Entity.EntityState.Modified;
            }

            context.SaveChanges();
            return district.districtId;
        }

        public District GetDistrictById(int Id)
        {
            return context.Districts.Where(w => w.districtId == Id).FirstOrDefault();
        }
        public District GetDistrictByName(string districtName)
        {
            return context.Districts.Where(w => w.districtName == districtName).FirstOrDefault();
        }

        public List<District> GetDuplicateDistrictName(int districtId, string districtName)
        {
            return context.Districts.Where(w => w.districtName == districtName && w.districtId != districtId).ToList();
        }

        public void DeleteDistrict(int districtId)
        {
            var c = context.Districts.Find(districtId);
            context.Districts.Remove(c);
            context.SaveChanges();
        }
    }
}
