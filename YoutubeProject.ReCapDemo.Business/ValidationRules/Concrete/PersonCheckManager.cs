using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.ReCapDemo.Business.ValidationRules.Abstract;
using YoutubeProject.ReCapDemo.Entities.Abstract;
using YoutubeProject.ReCapDemo.Entities.Concrete;

namespace YoutubeProject.ReCapDemo.Business.ValidationRules.Concrete
{
    public class PersonCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Person person)
        {
            if (person.Name.Trim().Length > 0 && person.LastName.Trim().Length > 0 && person.NationalityId.Trim().Length == 11 && person.DateOfBirth.Year > 1900) ;
            {
                return true;
            }
        }
    }
}
