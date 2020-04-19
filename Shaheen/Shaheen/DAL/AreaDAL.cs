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
            return context.Areas.ToList();
        }
    }
}
