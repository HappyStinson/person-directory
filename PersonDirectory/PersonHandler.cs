using System;

namespace PersonDirectory
{
    class PersonHandler
    {
        public Person CreatePerson(int age, string fname, string lname,
                                    double height, double weight)
        {
            return new Person()
            {
                Age = age,
                FirstName = fname,
                LastName = lname,
                Height = height,
                Weight = weight
            };
        }

        public void SetAge(Person pers, int age)
        {
            if (pers != null)
                pers.Age = age;
        }

        public string FullName(Person person)
        {
            if (person == null)
                return "";

            return person.LastName + ", " + person.FirstName; 
        }

        public int CalculateBirthYear(Person person)
        {
            if (person == null)
                return 0;

            return DateTime.Now.Year - person.Age;
        }

        public double CalculateBMI(Person person)
        {
            if (person == null)
                return 0;

            return person.Weight / (person.Height * person.Height);
        }
    }
}
