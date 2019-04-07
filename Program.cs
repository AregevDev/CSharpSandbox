using System;

namespace CSharpSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person { Name = "Hello", Age = 12 };
            Console.WriteLine(p.Name);
        }
    }
}
