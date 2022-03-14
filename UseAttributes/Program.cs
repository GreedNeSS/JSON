using System;
using System.Text.Json;

namespace UseAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Use Attributes *****");

            Person person = new Person()
            {
                Name = "Ruslan",
                Age = 30
            };

            string json = JsonSerializer.Serialize<Person>(person);

            Console.WriteLine($"\nperson: {person}");
            Console.WriteLine($"JSON: {json}");

            Person? restoredPerson = JsonSerializer.Deserialize<Person>(json);

            Console.WriteLine($"restoredPerson: {restoredPerson}");
        }
    }
}
