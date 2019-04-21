using System;
using System.Collections.Generic;

namespace CSharpSandbox
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            var map = new Dictionary<string, Person>
            {
                { "Alon", new Person { Name = "Alon", Age = 11 } },
                { "ImGay", new Person { Name = "ImgGay", Age = 14 } }
            };

            foreach (var i in map)
            {
                Console.WriteLine($"{i.Key} = {i.Value}");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
} 
