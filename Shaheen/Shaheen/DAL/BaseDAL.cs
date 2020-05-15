using Shaheen.ShaheenDB;
using System.Configuration;

namespace Shaheen.DAL
{
    public class BaseDAL
    {        
        public string ConnectionString = string.Empty;
        public BaseDAL()
        {            
            ConnectionString = ConfigurationManager.ConnectionStrings["ShaheenDB"].ConnectionString;
        }
    }
}
