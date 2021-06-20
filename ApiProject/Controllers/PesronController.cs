using Contracts.IServices;
using Entities;
using LoggerService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PesronController : Controller
    {
        private protected IRepositoryManager _repositoryManager;
        private protected ILoggerManager _logger;
        public PesronController(Contracts.IServices.IRepositoryManager repositoryManager, ILoggerManager loggerManager)

        {

        }
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            var persons = _repositoryManager.person.GetAllPersons(false);
            return persons;
        }
    }
}
