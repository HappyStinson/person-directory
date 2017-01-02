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
            var people = new Person[5];
            people[0] = handler.CreatePerson(age: 0, fname: "John", lname: "Doe", height: 0, weight: 0);
            people[1] = handler.CreatePerson(age: -5, fname: "Jane", lname: "Doe", height: 160, weight: 55);
            people[2] = handler.CreatePerson(age: 150, fname: "Jack", lname: "Ripper", height: 180, weight: 80);
            people[3] = handler.CreatePerson(age: 107, fname: "Bonnie", lname: "Parker", height: 163, weight: 71.5);
            people[4] = handler.CreatePerson(age: 108, fname: "Clyde", lname: "Barrow", height: 168, weight: 150);

            Console.WriteLine("Calling -> PrintSummary \n");
            foreach (var person in people)
            {
                PrintSummary(person);
                Console.WriteLine();
            }            

            handler.SetAge(people[1], 26);
            Console.WriteLine("Calling -> PrintStatistics \n");
            foreach (var person in people)
            {
                PrintStatistics(handler, person);
                Console.WriteLine();
            }
        }

        private static void PrintSummary(Person person)
        {
            Console.WriteLine($"Age: {person?.Age}");
            Console.WriteLine($"Firstname: {person?.FirstName}");
            Console.WriteLine($"Lastname: {person?.LastName}");
            Console.WriteLine($"Height: {person?.Height} cm");
            Console.WriteLine($"Weight: {person?.Weight} kg");
        }

        private static void PrintStatistics(PersonHandler handler, Person person)
        {
            Console.WriteLine($"{handler?.FullName(person)}");
            Console.WriteLine($"is {person?.Age} years of age");
            Console.WriteLine($"and was born in {handler?.CalculateBirthYear(person)}");
            var BMI = handler?.CalculateBMI(person);
            Console.WriteLine($"and has a BMI of: {BMI.Score:F2} wich is {BMI.Category}");
        }
    }
}
