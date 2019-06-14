using NineWebApp.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using static NineWebApp.Contracts.Enums;

namespace NineWebApp.Repository.Mocks
{
    public class PeopleRepository : IPeopleRepository
    {
        public List<Person> GetPeople()
        {
            return PeopleStub.InitPeople();
        }

        public List<Person> GetPeople(Race race)
        {
            throw new NotImplementedException();
        }
    }
}
