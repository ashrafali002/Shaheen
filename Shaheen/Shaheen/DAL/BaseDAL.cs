using Shaheen.ShaheenDB;
using System.Configuration;

namespace Shaheen.DAL
{
    public class BaseDAL
    {
        protected ShaheenEntities context;
        public string ConnectionString = string.Empty;
        public BaseDAL()
        {
            context = new ShaheenEntities();
            ConnectionString = ConfigurationManager.ConnectionStrings["ShaheenDB"].ConnectionString;
        }
    }
}
