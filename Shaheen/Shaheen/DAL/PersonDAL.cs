using Shaheen.ShaheenDB;
using System.Collections.Generic;
using System.Linq;

namespace Shaheen.DAL
{
    public class PersonDAL : BaseDAL
    {
        public PersonDAL()
        {
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
