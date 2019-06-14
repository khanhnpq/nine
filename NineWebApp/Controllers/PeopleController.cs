using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NineWebApp.Repository;

namespace NineWebApp.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private IPeopleRepository _repository;

        public PeopleController(IPeopleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet()]
        public ActionResult<List<Contracts.Person>> GetAll()
        {
            return _repository.GetPeople();
        }
    }
}