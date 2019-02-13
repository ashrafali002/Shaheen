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
        ShaheenEntities entities = new ShaheenEntities();
        public int SavePerson(Person person)
        {
            entities.People.Add(person);
            entities.SaveChanges();
            return person.personId;
        }
    }
}
