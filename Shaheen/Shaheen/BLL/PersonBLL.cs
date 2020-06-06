using Shaheen.DAL;
using Shaheen.IshraqEntities;
using Shaheen.Models;
using System.Data;

namespace Shaheen.BLL
{
    public class PersonBLL
    {
        public PersonDAL personDal;
        public PersonBLL()
        {
            personDal = new PersonDAL();
        }
        public Person GetPersonById(int Id)
        {
            return personDal.GetPersonById(Id);
        }

        public int SavePerson(Person person)
        {
            return personDal.SavePerson(person);
        }
        public PersonModel GetPersonModelById(int personId)
        {
            return personDal.GetPersonModelById(personId);
        }

        public DataTable GetPersonTable()
        {
            return personDal.GetPersonTable();
        }
        
    }
}
