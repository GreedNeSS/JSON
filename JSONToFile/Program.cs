using System;
using System.Text.Json;
using System.IO;

namespace JSONToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** JSON To File *****");

            string path = @"F:\Text\Person.json";

            using FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
        }
    }
}
