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
                var race = (Enums.Race)raceRandom.Next(1, 5);

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
                    people.Add(new Hawaiian()
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
    }
}
