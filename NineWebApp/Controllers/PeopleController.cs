using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NineWebApp.Contracts;
using NineWebApp.Repository;
using NineWebApp.Services;

namespace NineWebApp.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private IPeopleRepository _repository;
        private IPeopleService _service;

        public PeopleController(IPeopleRepository repository, IPeopleService service)
        {
            _repository = repository;
            _service = service;
        }

        [HttpGet()]
        public ActionResult<List<Contracts.Person>> GetAll()
        {
            return _repository.GetPeople();
        }

        [HttpGet("get/summary")]
        public ActionResult<Summary> GetSummary()
        {
            return _service.GetSummary(_repository.GetPeople());
        }

        [HttpGet("get/{race}")]
        public ActionResult<List<Contracts.Person>> GetByRace(string race)
        {
            return _repository.GetPeople(race);
        }
    }
}