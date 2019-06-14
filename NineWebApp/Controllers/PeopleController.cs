using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
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
        private IMemoryCache _cache;
        private IConfiguration _configuration;
        private MemoryCacheEntryOptions _cacheEntryOptions;

        public static readonly string PEOPLE_CacheKey = "PEOPLE";

        public PeopleController(IPeopleRepository repository, IPeopleService service, IMemoryCache cache, IConfiguration configuration)
        {
            _repository = repository;
            _service = service;
            _cache = cache;
            _configuration = configuration;

            _cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetSize(Convert.ToInt32(_configuration["CachingConfigurations:CachedSize"]))
                .SetSlidingExpiration(TimeSpan.FromMinutes(Convert.ToInt32(_configuration["CachingConfigurations:CachedMinutes"])));
        }

        [HttpGet()]
        public ActionResult<List<Contracts.Person>> GetAll()
        {
            return GetPeopleList();
        }

        [HttpGet("get/add1age")]
        public ActionResult<List<Contracts.Person>> GetAllWithAddedAge()
        {
            var cacheEntry = _service.AddAge(GetPeopleList(), 1);
            _cache.Set(PEOPLE_CacheKey, cacheEntry, _cacheEntryOptions);

            return cacheEntry;
        }

        [HttpGet("get/summary")]
        public ActionResult<Summary> GetSummary()
        {
            return _service.GetSummary(GetPeopleList());
        }

        private List<Person> GetPeopleList()
        {
            var hasCachedPEOPLE = _cache.TryGetValue(PEOPLE_CacheKey, out List<Person> cacheEntry);

            if (!hasCachedPEOPLE)
            {
                cacheEntry = _repository.GetPeople();
                _cache.Set(PEOPLE_CacheKey, cacheEntry, _cacheEntryOptions);
            }
            return cacheEntry;
        }


        [HttpGet("get/{race}")]
        public ActionResult<List<Contracts.Person>> GetByRace(string race)
        {
            return _repository.GetPeople(race);
        }
    }
}