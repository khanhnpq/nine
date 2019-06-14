using NineWebApp.Contracts;
using System.Linq;
using System.Collections.Generic;

namespace NineWebApp.Repository.Mocks
{
    public class PeopleRepository : IPeopleRepository
    {
        public List<Person> GetPeople()
        {
            return PeopleStub.InitPeople();
        }

        public List<Person> GetPeople(string race)
        {
            return PeopleStub.InitPeople().Where(person => person.Race == race.ToLowerInvariant()
                                                        && person.Age % 2 == 0)
                                          .OrderBy(person => person.Age).ToList();
        }
    }
}
