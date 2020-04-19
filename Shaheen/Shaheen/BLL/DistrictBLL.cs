using Shaheen.DAL;
using Shaheen.ShaheenDB;
using Shaheen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.BLL
{
    public class DistrictBLL
    {
        public DistrictDAL stateDal;
        public DistrictBLL()
        {
            stateDal = new DistrictDAL();
        }
        public List<District> DistrictList()
        {
            var list = stateDal.DistrictList();
            return list;
        }

        public List<DistrictState> DistrictStateList()
        {
            return stateDal.DistrictStateList();
        }

        public int SaveDistrict(District state)
        {
            return stateDal.SaveDistrict(state);
        }

        public District GetDistrictById(int Id)
        {
            return stateDal.GetDistrictById(Id);
        }
        public District GetDistrictByName(string stateName)
        {
            return stateDal.GetDistrictByName(stateName);
        }
        public bool IsDuplicateDistrictName(int stateId, string stateName)
        {
            var isDuplicateFound = true;
            var duplicateList = stateDal.GetDuplicateDistrictName(stateId, stateName);
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
            stateDal.DeleteDistrict(districtId);

        }
    }
}