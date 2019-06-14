namespace NineWebApp.Contracts
{
    public class Person
    {
        protected double height;
        public string Name { get; set; }
        public int Age { get; set; }

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
    }

    public class Saxon : Angle
    {

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
    }
}
