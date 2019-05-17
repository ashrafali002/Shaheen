using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.BLL
{
    public class DistrictBLL
    {
        ShaheenEntities context = null;
        public DistrictBLL()
        {
            context = new ShaheenEntities();
        }
        public List<District> DistrictList()
        {
            return context.Districts.ToList();
        }
    }
}
