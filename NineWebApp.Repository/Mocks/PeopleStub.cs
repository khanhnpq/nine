using NineWebApp.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NineWebApp.Repository.Mocks
{
    public static class PeopleStub
    {
        

        public static List<Person> InitPeople()
        {
            List<Person> people = new List<Person>();
            Random ageRandom = new Random();
            Random raceRandom = new Random();
            
            for (int i = 1; i <= 10000; i++)
            {
                var race = (Enums.Race)raceRandom.Next(1, 4);

                if(race is Enums.Race.Angle)
                {
                    people.Add(new Angle()
                    {
                        Name = $@"Person #{i} is {Enums.Race.Angle.ToString()}",
                        Age = ageRandom.Next(1, 99)
                    });
                }

                if (race is Enums.Race.Saxon)
                {
                    people.Add(new Saxon()
                    {
                        Name = $@"Person #{i} is {Enums.Race.Saxon.ToString()}",
                        Age = ageRandom.Next(1, 99)
                    });
                }

                if (race is Enums.Race.Jute)
                {
                    people.Add(new Jute()
                    {
                        Name = $@"Person #{i} is {Enums.Race.Jute.ToString()}",
                        Age = ageRandom.Next(1, 99)
                    });
                }

                if (race is Enums.Race.Hawaiian)
                {
                    people.Add(new Jute()
                    {
                        Name = $@"Person #{i} is {Enums.Race.Hawaiian.ToString()}",
                        Age = ageRandom.Next(1, 99)
                    });
                }

                //people.Add(new Person()
                //{
                //    Name = "Person #" + i.ToString(),
                //    Age = ageRandom.Next(1, 99)
                    
                //});
            }
            return people;
        }

        public static List<Person> InitPeople1()
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
