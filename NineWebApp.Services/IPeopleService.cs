using NineWebApp.Contracts;
using System.Collections.Generic;

namespace NineWebApp.Services
{
    public interface IPeopleService
    {
        Summary GetSummary(List<Person> peopleList);
    }
}
