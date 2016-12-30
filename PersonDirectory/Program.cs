using System;

namespace PersonDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person()
            //{
            //    Age = 26,
            //    FirstName = "John",
            //    LastName = "Doe",
            //    Height = 175,
            //    Weight = 75
            //};

            var handler = new PersonHandler();
            var person = handler.CreatePerson(0, "John", "Doe", 1.75, 75);

            PrintPerson(person);
            Console.WriteLine();

            handler.SetAge(person, 26);
            Console.WriteLine($"{handler?.FullName(person)}");
            Console.WriteLine($"is {person?.Age} years of age");
            Console.WriteLine($"and was born in {handler?.CalculateBirthYear(person)}");
            var BMI = handler?.CalculateBMI(person);
            Console.WriteLine($"and has a BMI of: {BMI.Score:F2} wich is {BMI.Category}");
        }

        private static void PrintPerson(Person person)
        {
            Console.WriteLine($"Age: {person?.Age}");
            Console.WriteLine($"Firstname: {person?.FirstName}");
            Console.WriteLine($"Lastname: {person?.LastName}");
            Console.WriteLine($"Height: {person?.Height}");
            Console.WriteLine($"Weight: {person?.Weight}");
        }
    }
}
