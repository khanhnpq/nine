using Newtonsoft.Json;

namespace NineWebApp.Contracts
{
    public class Person
    {
        protected double height;
       // protected string race;

        public string Name { get; set; }
        public int Age { get; set; }

        //[JsonIgnore]
        public virtual string Race
        {
            get { return Enums.Race.Unknown.ToString().ToLowerInvariant(); }
           // set { race = value; }
        }

        
        public virtual double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public override string ToString()
        {
            return "My name is '" + Name + "' and I am " + Age + " years old.";
        }
    }

    public class Angle : Person
    {
        public override double Height
        {
            get
            {
                return (1.5 + (Age * 0.45));
            }
            set
            {
                height = value;
            }
        }

        //[JsonIgnore]
        public override string Race
        {
            get { return Enums.Race.Angle.ToString().ToLowerInvariant(); }
        }
    }

    public class Saxon : Angle
    {
        //[JsonIgnore]
        public override string Race
        {
            get { return Enums.Race.Saxon.ToString().ToLowerInvariant(); }
        }
    }

    public class Jute : Person
    {
        public override double Height
        {
            get
            {
                return ((Age * 1.6) / 2);
            }
            set
            {
                height = value;
            }
        }

        //[JsonIgnore]
        public override string Race
        {
            get { return Enums.Race.Jute.ToString().ToLowerInvariant(); }
        }
    }

    public class Hawaiian : Person
    {
        public override double Height
        {
            get
            {
                return (1.7 + ((Age + 2) * 0.23));
            }
            set
            {
                height = value;
            }
        }

        //[JsonIgnore]
        public override string Race
        {
            get { return Enums.Race.Hawaiian.ToString().ToLowerInvariant(); }
        }
    }
}
