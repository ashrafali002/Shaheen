using Shaheen.DAL;
using System.Data;

namespace Shaheen.BLL
{
    public class ReportBLL
    {
        public ReportDAL reportDal;
        public ReportBLL()
        {
            reportDal = new ReportDAL();
        }
        public DataTable GetPersonForLablePrint()
        {
            return reportDal.GetPersonForLablePrint();
        }

        public DataTable GetCustomizedPersonList(string whereCondition)
        {
            return reportDal.GetCustomizedPersonList(whereCondition);
        }
        public DataTable GetAgentWiseStatusCount()
        {
            return reportDal.GetAgentWiseStatusCount();
        }
        public DataTable GetStatusWiseCount()
        {
            return reportDal.GetStatusWiseCount();
        }
    }
}
