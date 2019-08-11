using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.DAL
{
    public class BaseDAL : IBaseDAL
    {
        protected ShaheenEntities context;

        public BaseDAL()
        {
            context = new ShaheenEntities();
        }
    }
}
