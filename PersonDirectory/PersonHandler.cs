using System;

namespace PersonDirectory
{
    class PersonHandler
    {
        public Person CreatePerson(int age, string fname, string lname,
                                    double height, double weight)
        {
            return new Person(age, fname, lname, height, weight);
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

        public BodyMassIndex CalculateBMI(Person person)
        {
            if (person == null)
                return null;

            return new BodyMassIndex(person.Weight, person.Height);
        }

        public string PersonSummary(Person person)
        {
            if (person == null)
                return null;

            return $"Age: {person.Age} \nFirstname: {person.FirstName} \nLastname: {person.LastName} \nHeight: {person.Height} cm \nWeight: {person.Weight} kg";
        }

        public string PersonStatistics(Person person)
        {
            if (person == null)
                return null;

            var BMI = CalculateBMI(person);
            return $"{ FullName(person)} \nis {person.Age} years of age \nand was born in {CalculateBirthYear(person)} \nand has a BMI of: {BMI.Score:F2} wich is {BMI.Category}";
        }
    }
}
