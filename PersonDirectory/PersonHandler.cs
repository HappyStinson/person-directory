using System;

namespace PersonDirectory
{
    class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            if (pers != null)
                pers.Age = age;
        }

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
    }
}
