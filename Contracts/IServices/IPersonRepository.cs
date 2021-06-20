using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Contracts.IServices
{
    public interface IPersonRepository
    {
        public IEnumerable<Person> GetAllPersons(bool trackChanges);
        public Person GetPersonByPhoneNumber(bool trackChanges, string phoneNumber);
        public Person GetPhoneNumberByName(bool trackChanges, string name);
    }
}
