using Shaheen.ShaheenDB;

namespace Shaheen.DAL
{
    public class BaseDAL
    {
        protected ShaheenEntities context;

        public BaseDAL()
        {
            context = new ShaheenEntities();
        }
    }
}
