using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
