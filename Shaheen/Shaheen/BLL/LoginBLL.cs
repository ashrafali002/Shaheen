using Shaheen.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.BLL
{
    public class LoginBLL
    {
        public LoginDAL loginDal;
        public LoginBLL()
        {
            loginDal = new LoginDAL();
        }
        public DataRow[] LoginTable(string userName, string password)
        {
            DataRow[] drArray = loginDal.LoginTable().Select("Username = '" + userName + "' AND Password = '" + password + "'");            
            return drArray;
        }
    }
}
