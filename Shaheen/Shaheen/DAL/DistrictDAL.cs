using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.DAL
{
    public class DistrictDAL
    {
        ShaheenEntities context = null;
        public DistrictDAL()
        {
            context = new ShaheenEntities();
        }
        public List<District> DistrictList()
        {
            return context.Districts.ToList();
        }
    }
}
