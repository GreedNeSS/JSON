using System;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text;

namespace JSONToFile
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("***** JSON To File *****");

            string path = @"F:\Text\Person.json";

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Person person = new Person("Ruslan", 30);
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                await JsonSerializer.SerializeAsync(fs, person, options);
            }

            using (FileStream fsr = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[fsr.Length];
                await fsr.ReadAsync(buffer, 0, buffer.Length);
                fsr.Position = 0;
                string json = Encoding.Default.GetString(buffer);

                Console.WriteLine($"{path}:\n{json}");

                Person? restoredPerson = await JsonSerializer.DeserializeAsync<Person>(fsr);

                Console.WriteLine($"\nrestoredPerson?.Name: {restoredPerson?.Name}");
                Console.WriteLine($"restoredPerson?.Age: {restoredPerson?.Age}");
            }
        }
    }
}
