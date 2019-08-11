using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.DAL
{
    public class PersonDAL : BaseDAL
    {
        public PersonDAL()
        {
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
