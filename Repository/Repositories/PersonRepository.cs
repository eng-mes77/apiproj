using System;
using System.Collections.Generic;
using System.Text;
using Contracts.IServices;
using Entities;
using System.Linq;

namespace Repository.Repositories
{
    public class PersonRepository : RepositoryBase<Person>,
         IPersonRepository
    {
        public PersonRepository(PersonDbContext personDbContext)
            : base(personDbContext)
        {

        }

        public IEnumerable<Person> GetAllPersons(bool trackChanges) =>
        FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

        public Person GetPersonByPhoneNumber(bool trackChanges, string phoneNumber) =>
            FindByCondition(x => x.Phone == phoneNumber, trackChanges).FirstOrDefault();

        public Person GetPhoneNumberByName(bool trackChanges, string name) =>
            FindByCondition(x => x.Name == name, trackChanges).FirstOrDefault();
    }
}
