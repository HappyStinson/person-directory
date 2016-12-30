using System;

namespace PersonDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                Age = 26,
                FirstName = "John",
                LastName = "Doe",
                Height = 175,
                Weight = 75
            };

            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Firstname: {person.FirstName}");
            Console.WriteLine($"Lastname: {person.LastName}");
            Console.WriteLine($"Height: {person.Height}");
            Console.WriteLine($"Weight: {person.Weight}");
        }
    }
}
