using Shaheen.DAL;
using Shaheen.Models;
using Shaheen.ShaheenDB;
using System.Collections.Generic;
using System.Linq;

namespace Shaheen.BLL
{
    public class DistrictBLL
    {
        public DistrictDAL districtDal;
        public DistrictBLL()
        {
            districtDal = new DistrictDAL();
        }
        public List<District> DistrictList()
        {
            var list = districtDal.DistrictList();
            return list;
        }

        public List<DistrictState> DistrictStateList()
        {
            return districtDal.DistrictStateList();
        }

        public int SaveDistrict(District district)
        {
            return districtDal.SaveDistrict(district);
        }

        public District GetDistrictById(int Id)
        {
            return districtDal.GetDistrictById(Id);
        }
        public District GetDistrictByName(string districtName)
        {
            return districtDal.GetDistrictByName(districtName);
        }
        public bool IsDuplicateDistrictName(int districtId, string districtName)
        {
            var isDuplicateFound = true;
            var duplicateList = districtDal.GetDuplicateDistrictName(districtId, districtName);
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

        public void DeleteDistrict(int districtId)
        {
            districtDal.DeleteDistrict(districtId);

        }
    }
}