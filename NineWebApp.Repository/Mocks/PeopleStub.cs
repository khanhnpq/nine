using NineWebApp.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NineWebApp.Repository.Mocks
{
    public static class PeopleStub
    {
        public static List<Person> InitPeople1()
        {
            List<Person> people = new List<Person>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                people.Add(new Person()
                {
                    Name = "Person #" + i.ToString(),
                    Age = rnd.Next(1, 99)
                });
            }
            return people;
        }

        public static List<Person> InitPeople()
        {
            List<Person> people = new List<Person>();

            people.Add(new Person() { Name = "Person #1", Age = 25, Height = 1.7 });
            people.Add(new Angle() { Name = "Person #2 Angle", Age = 26, Height = 1.8 });
            people.Add(new Saxon() { Name = "Person #3 Saxon", Age = 27, Height = 1.9 });
            people.Add(new Jute() { Name = "Person #4 Jute", Age = 28, Height = 1.6 });
            people.Add(new Hawaiian() { Name = "Person #5 Hawaiian", Age = 29, Height = 1.5 });

            return people;
        }
    }
}
