using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmAdmin : BaseForm
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnClearDatabase_Click(object sender, EventArgs e)
        {
            ClearDatabase();
            ResetIds();
        }

        private void ClearDatabase()
        {
            //1-Country
            StringBuilder str = new StringBuilder();
            str.Append("Delete From Country;");
            string ConnectionString = ConfigurationManager.ConnectionStrings["IshraqConnectionString"].ConnectionString;
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //2-State
            str = new StringBuilder();
            str.Append("Delete From State;");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //3-District
            str = new StringBuilder();
            str.Append("Delete From District;");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //4-City
            str = new StringBuilder();
            str.Append("Delete From City;");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //5-Area
            str = new StringBuilder();
            str.Append("Delete From Area;");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //6-Agent
            str = new StringBuilder();
            str.Append("Delete From Agent;");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //7-SubscriptionDetail
            str = new StringBuilder();
            str.Append("Delete From SubscriptionDetail;");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //8-Payment
            str = new StringBuilder();
            str.Append("Delete From Payment;");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //9-Subscription
            str = new StringBuilder();
            str.Append("Delete From Subscription;");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //10-Person
            str = new StringBuilder();
            str.Append("Delete From Person;");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
        }
        private void ResetIds()
        {
            //1-Country
            StringBuilder str = new StringBuilder();
            str.Append("ALTER TABLE Country ALTER COLUMN countryId IDENTITY (1,1);");
            string ConnectionString = ConfigurationManager.ConnectionStrings["IshraqConnectionString"].ConnectionString;
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //2-State
            str = new StringBuilder();            
            str.Append("ALTER TABLE State ALTER COLUMN stateId IDENTITY (1,1);");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //3-District
            str = new StringBuilder();
            str.Append("ALTER TABLE District ALTER COLUMN districtId IDENTITY (1,1);");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //4-City
            str = new StringBuilder();            
            str.Append("ALTER TABLE City ALTER COLUMN cityId IDENTITY (1,1);");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //5-Area
            str = new StringBuilder();
            str.Append("ALTER TABLE Area ALTER COLUMN areaId IDENTITY (1,1);");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //6-Agent
            str = new StringBuilder();
            str.Append("ALTER TABLE Agent ALTER COLUMN agentId IDENTITY (1,1);");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //7-SubscriptionDetail
            str = new StringBuilder();
            str.Append("ALTER TABLE SubscriptionDetail ALTER COLUMN subscriptionDetailId IDENTITY (1,1);");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //8-Payment
            str = new StringBuilder();
            str.Append("ALTER TABLE Payment ALTER COLUMN paymentId IDENTITY (1,1);");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //9-Subscription
            str = new StringBuilder();            
            str.Append("ALTER TABLE Subscription ALTER COLUMN subscriptionId IDENTITY (1,1);");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
            //10-Person
            str = new StringBuilder();            
            str.Append("ALTER TABLE Person ALTER COLUMN personId IDENTITY (1,1);");
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(str.ToString(), con);
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
            }
        }
    }
}
