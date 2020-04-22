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

        public int SaveDistrict(District state)
        {
            return districtDal.SaveDistrict(state);
        }

        public District GetDistrictById(int Id)
        {
            return districtDal.GetDistrictById(Id);
        }
        public District GetDistrictByName(string stateName)
        {
            return districtDal.GetDistrictByName(stateName);
        }
        public bool IsDuplicateDistrictName(int stateId, string stateName)
        {
            var isDuplicateFound = true;
            var duplicateList = districtDal.GetDuplicateDistrictName(stateId, stateName);
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