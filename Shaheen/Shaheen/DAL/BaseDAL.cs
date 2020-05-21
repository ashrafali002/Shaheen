using System.Configuration;

namespace Shaheen.DAL
{
    public class BaseDAL
    {        
        public string ConnectionString = string.Empty;
        public BaseDAL()
        {            
            ConnectionString = ConfigurationManager.ConnectionStrings["IshraqConnectionString"].ConnectionString;
        }
    }
}
