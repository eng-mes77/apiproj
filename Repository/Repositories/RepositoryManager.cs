using System;
using System.Collections.Generic;
using System.Text;
using Contracts.IServices;
using Entities;

namespace Repository.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private PersonDbContext _repositoryContext;
        private IPersonRepository _personRepository;

        public RepositoryManager(PersonDbContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IPersonRepository person
        {
            get
            {
                if (_personRepository == null)
                    _personRepository = new
                    PersonRepository(_repositoryContext);
                return _personRepository;
            }
        }
        public void save() => _repositoryContext.SaveChanges();
    }
}
