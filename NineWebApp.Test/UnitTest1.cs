using NineWebApp.Contracts;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        List<Person> people = new List<Person>();

        [SetUp]
        public void Setup()
        {
            people.Add(new Person() { Name = "Person #1", Age = 25, Height = 1.7 });
            people.Add(new Angle() { Name = "Person #2 Angle", Age = 26, Height = 1.8 });
            people.Add(new Saxon() { Name = "Person #3 Saxon", Age = 27, Height = 1.9 });
            people.Add(new Jute() { Name = "Person #4 Jute", Age = 28, Height = 1.6 });
            people.Add(new Hawaiian() { Name = "Person #5 Hawaiian", Age = 29, Height = 1.5 });
        }

        [Test]
        public void AngleSaxonHeightTest()
        {
            var angle = people.Where(person => person.Race == Enums.Race.Angle.ToString().ToLower()).ToList().FirstOrDefault();
            var expected = (1.5 + (angle.Age * 0.45));
            Assert.AreEqual(angle.Height, expected);
        }

        [Test]
        public void JuteHeightTest()
        {
            var jute = people.Where(person => person.Race == Enums.Race.Jute.ToString().ToLower()).ToList().FirstOrDefault();
            var expected = ((jute.Age * 1.6) / 2);
            Assert.AreEqual(jute.Height, expected);
        }

        [Test]
        public void HawaiianHeightTest()
        {
            var hawaiian = people.Where(person => person.Race == Enums.Race.Hawaiian.ToString().ToLower()).ToList().FirstOrDefault();
            var expected = (1.7 + ((hawaiian.Age + 2) * 0.23));
            Assert.AreEqual(hawaiian.Height, expected);
        }
    }
}