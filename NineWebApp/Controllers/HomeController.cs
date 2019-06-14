using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using NineWebApp.Contracts;
using NineWebApp.Repository;
using NineWebApp.Services;

namespace NineWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IPeopleRepository _repository;
        private IPeopleService _service;
        private IMemoryCache _cache;
        private IConfiguration _configuration;
        private MemoryCacheEntryOptions _cacheEntryOptions;
        public static readonly string PEOPLE_CacheKey = "PEOPLE";

        public HomeController(IPeopleRepository repository, IPeopleService service, IMemoryCache cache, IConfiguration configuration)
        {
            _repository = repository;
            _service = service;
            _cache = cache;
            _configuration = configuration;

            _cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetSize(Convert.ToInt32(_configuration["CachingConfigurations:CachedSize"]))
                .SetSlidingExpiration(TimeSpan.FromMinutes(Convert.ToInt32(_configuration["CachingConfigurations:CachedMinutes"])));
        }

        public IActionResult Index()
        {
            return View(GetPeopleList());
        }

        public IActionResult Race(string race)
        {
            return View(_service.FilterByFace(GetPeopleList(), race));
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
    }
}