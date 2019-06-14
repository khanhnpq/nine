using NineWebApp.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using static NineWebApp.Contracts.Enums;

namespace NineWebApp.Services
{
    public class PeopleService : IPeopleService
    {
        public Summary GetSummary(List<Person> peopleList)
        {
            int total = peopleList.Count();
            int avarageAge = peopleList.Sum(person => person.Age) / total;
            int maxAge = peopleList.Max(person => person.Age);
            int minAge = peopleList.Min(person => person.Age);

            int totalAngle = peopleList.Where(person => person.Race == Enums.Race.Angle.ToString().ToLowerInvariant()).Count();
            int totalSaxon = peopleList.Where(person => person.Race == Enums.Race.Saxon.ToString().ToLowerInvariant()).Count();
            int totalJute = peopleList.Where(person => person.Race == Enums.Race.Jute.ToString().ToLowerInvariant()).Count();
            int totalHawaiian = peopleList.Where(person => person.Race == Enums.Race.Hawaiian.ToString().ToLowerInvariant()).Count();

            return new Summary
            {
                Total = total,
                AvarageAge = avarageAge,
                MaxAge = maxAge,
                MinAge = minAge,
                TotalAngle = totalAngle,
                TotalSaxon = totalSaxon,
                TotalJute = totalJute,
                TotalHawaiian = totalHawaiian
            };
        }

        
    }
}
