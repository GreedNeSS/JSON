using System;
using System.Text.Json;
using System.IO;

namespace SimpleSerializeDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Serialize Deserialize JSON *****");

            Person person = new Person("Ruslan", 30);
            string perStr = JsonSerializer.Serialize<Person>(person);

            Console.WriteLine($"Json: {perStr}");

            Person? restoredPerson = JsonSerializer.Deserialize<Person>(perStr);

            Console.WriteLine($"restoredPerson.Name: {restoredPerson?.Name}");
        }
    }
}
