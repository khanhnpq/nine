using NineWebApp.Contracts;
using System.Collections.Generic;
using static NineWebApp.Contracts.Enums;

namespace NineWebApp.Repository
{
    public interface IPeopleRepository
    {
        List<Person> GetPeople();
        List<Person> GetPeople(string race);
    }
}
