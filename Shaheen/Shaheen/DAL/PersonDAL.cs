using Shaheen.IshraqEntities;
using Shaheen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;

namespace Shaheen.DAL
{
    public class PersonDAL : BaseDAL
    {
        protected IshraqContext context;
        public PersonDAL()
        {
            context = new IshraqContext();
        }
        public List<Person> getPersonList()
        {
            var personList = context.People.ToList();
            return personList;
        }
        public Person GetPersonById(int Id)
        {
            return context.People.Where(w => w.personId == Id).FirstOrDefault();
        }

        public PersonModel GetPersonModelById(int personId)
        {
            var personModel = new PersonModel();
            personModel = PersonFull().Where(w => w.personId == personId).FirstOrDefault();
            return personModel;
        }

        public DataTable GetPersonTable()
        {
            DataTable dt = new DataTable();
            string strQuery = @"Select P.personId,P.personName,P.personAddress,P.areaId,A.areaName,P.cityId,CT.cityName,
                P.districtId,D.districtName,P.stateId,S.stateName,P.countryId,C.countryName,P.pin,P.phone,P.mobile,P.email
                From Person P 
                LEFT OUTER JOIN Country C ON P.countryId = C.countryId
                LEFT OUTER JOIN State S ON P.stateId = S.stateId
                LEFT OUTER JOIN District D ON P.districtId = D.districtId
                LEFT OUTER JOIN City CT ON P.cityId = CT.cityId
                LEFT OUTER JOIN Area A ON P.areaId = A.areaId";
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand(strQuery, con);
                cmd.CommandType = CommandType.Text;
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        public List<PersonModel> PersonFull()
        {
            var list = new List<PersonModel>();
            DataTable dt = new DataTable();
            dt = GetPersonTable();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new PersonModel()
                    {
                        personId = Convert.ToInt32(dr["personId"]),
                        personName = CommonFunctions.NullToString(dr["personName"]),
                        personAddress = CommonFunctions.NullToString(dr["personAddress"]),
                        areaId = CommonFunctions.NullToInt(dr["areaId"]),
                        areaName = CommonFunctions.NullToString(dr["areaName"]),
                        cityId = CommonFunctions.NullToInt(dr["cityId"]),
                        cityName = CommonFunctions.NullToString(dr["cityName"]),
                        districtId = CommonFunctions.NullToInt(dr["districtId"]),
                        districtName = CommonFunctions.NullToString(dr["districtName"]),
                        stateId = CommonFunctions.NullToInt(dr["stateId"]),
                        stateName = CommonFunctions.NullToString(dr["stateName"]),
                        countryId = CommonFunctions.NullToInt(dr["countryId"]),
                        countryName = CommonFunctions.NullToString(dr["countryName"]),
                        pin = CommonFunctions.NullToString(dr["pin"]),
                        phone = CommonFunctions.NullToString(dr["phone"]),
                        mobile = CommonFunctions.NullToString(dr["mobile"]),
                        email = CommonFunctions.NullToString(dr["email"])
                    });
                }
            }
            return list;
            //list = context.People.Join(context.Countries, ag => ag.countryId, cn => cn.countryId, (ag, cn) => new { ag, cn })
            //    .Join(context.States, ag => ag.ag.stateId, st => st.stateId, (ag, st) => new { ag, st })
            //    .Join(context.Districts, ag => ag.ag.ag.districtId, dt => dt.districtId, (ag, dt) => new { ag, dt })
            //    .Join(context.Cities, ag => ag.ag.ag.ag.cityId, ct => ct.cityId, (ag, ct) => new { ag, ct })
            //    .Join(context.Areas, ag => ag.ag.ag.ag.ag.areaId, aa => aa.areaId, (ag, aa) => new { ag, aa })
            //    .Select(m => new PersonModel
            //    {
            //        personId = m.ag.ag.ag.ag.ag.personId,
            //        personName = m.ag.ag.ag.ag.ag.personName,
            //        personAddress = m.ag.ag.ag.ag.ag.personAddress,
            //        areaId = m.ag.ag.ag.ag.ag.areaId,
            //        areaName = m.aa.areaName,
            //        cityId = m.ag.ag.ag.ag.ag.cityId,
            //        cityName = m.ag.ct.cityName,
            //        districtId = m.ag.ag.ag.ag.ag.districtId,
            //        districtName = m.ag.ag.dt.districtName,
            //        stateId = m.ag.ag.ag.ag.ag.stateId,
            //        stateName = m.ag.ag.ag.st.stateName,
            //        countryId = m.ag.ag.ag.ag.ag.countryId,
            //        countryName = m.ag.ag.ag.ag.cn.countryName,
            //        pin = m.ag.ag.ag.ag.ag.pin,
            //        phone = m.ag.ag.ag.ag.ag.phone,
            //        mobile = m.ag.ag.ag.ag.ag.mobile,
            //        email = m.ag.ag.ag.ag.ag.email
            //    }).ToList();

        }

        public int SavePerson(Person person)
        {
            if (person.personId == 0)
            {
                context.People.Add(person);
            }
            else
            {
                Person p = context.People.Find(person.personId);
                p.personName = person.personName;
                p.personAddress = person.personAddress;
                p.countryId = person.countryId;
                p.stateId = person.stateId;
                p.districtId = person.districtId;
                p.cityId = person.cityId;
                p.areaId = person.areaId;
                p.pin = person.pin;
                p.phone = person.phone;
                p.mobile = person.mobile;
                p.email = person.email;
                context.Entry(p).State = System.Data.Entity.EntityState.Modified;
            }

            context.SaveChanges();
            return person.personId;
        }        

        
    }
}
