using NineWebApp.Contracts;
using System.Linq;
using System.Collections.Generic;
using static NineWebApp.Contracts.Enums;

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
            var list = PeopleStub.InitPeople();

            var raceList = PeopleStub.InitPeople().Where(person => person.Race == race.ToLowerInvariant()).ToList();
            var raceAgeList = PeopleStub.InitPeople().Where(person => person.Race == race.ToLowerInvariant()
                                                        && person.Age % 2 == 0);


            return PeopleStub.InitPeople().Where(person => person.Race == race.ToLowerInvariant()
                                                        && person.Age % 2 == 0)
                                          .OrderBy(person => person.Age).ToList();
        }
    }
}
