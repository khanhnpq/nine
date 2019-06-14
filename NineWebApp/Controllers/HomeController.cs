using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NineWebApp.Repository;

namespace NineWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IPeopleRepository _repository;

        public HomeController(IPeopleRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View(_repository.GetPeople());
        }

        public IActionResult Race(string race)
        {
            return View(_repository.GetPeople(race));
        }
    }
}