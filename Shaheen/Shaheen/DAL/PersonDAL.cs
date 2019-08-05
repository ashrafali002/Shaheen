using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.DAL
{
    public class PersonDAL
    {
        ShaheenEntities context = null;
        public PersonDAL()
        {
            context = new ShaheenEntities();
        }
        public int SavePerson(Person person)
        {
            context.People.Add(person);
            context.SaveChanges();
            return person.personId;
        }
        public List<Person> getPersonList()
        {
            var personList = context.People.ToList();
            return personList;
        }
    }
}
