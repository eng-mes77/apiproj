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
        public PersonRepository(PersonDbContext companyEmployeeDbContext)
            : base(companyEmployeeDbContext)
        {

        }

        public IEnumerable<Person> GetAllPersons(bool trackChanges) =>
        FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();
    }
}
