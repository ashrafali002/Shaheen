﻿using Shaheen.DAL;
using Shaheen.Models;
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
    }
}
