namespace PersonDirectory
{
    internal class Person
    {
        private int age;
        private string fname;
        private string lname;
        private double height;
        private double weight;

        public Person() { }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string FirstName
        {
            get { return fname; }
            set { fname = value; }
        }

        public string LastName
        {
            get { return lname; }
            set { lname = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}