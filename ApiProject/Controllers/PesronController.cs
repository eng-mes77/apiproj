using Contracts.IServices;
using Entities;
using Microsoft.AspNetCore.Http;
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
        public PesronController(Contracts.IServices.IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        [Consumes("application/xml")]
        [HttpPost]
        public ActionResult<Person> NameByPhoneNumber([FromBody] Phone phoneNumber)
        {
            try
            {
                var person = _repositoryManager.person.GetPersonByPhoneNumber(trackChanges: false, phoneNumber.phoneNumber);
                return person;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        //[HttpPost]
        //public ActionResult<string> PhoneByPersonName([FromBody] string personName)
        //{
        //    var phoneNumber = _repositoryManager.person.GetPhoneNumberByName(trackChanges: false, personName).Phone;
        //    return phoneNumber;
        //}
    }
}
