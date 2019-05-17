using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen.BLL
{
    public class PersonBLL
    {
        ShaheenEntities context = null;
        public PersonBLL()
        {
            context = new ShaheenEntities();
        }
        public int SavePerson(Person person)
        {
            context.People.Add(person);
            context.SaveChanges();
            return person.personId;
        }
    }
}
