using NineWebApp.Contracts;
using System.Collections.Generic;

namespace NineWebApp.Services
{
    public interface IPeopleService
    {
        Summary GetSummary(List<Person> peopleList);
        List<Person> AddAge(List<Person> peopleList, int numberOfYear);
        List<Person> FilterByFace(List<Person> peopleList, string race);
    }
}
