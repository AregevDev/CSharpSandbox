using System;
using System.Threading.Tasks;

namespace CSharpSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Runner();
                Console.ReadLine();
            }
        }
        
        static async void Runner()
        {
            int t = await Task.Run(() => Allocate());
            Console.WriteLine($"Compute: {t}");
        }

        static int Allocate()
        {
            int size = 0;
            Random r = new Random();
            for (int z = 0; z < 100; z++)
            {
                Person p = new Person { Age = r.Next(0, 101) };
                size += p.Age;
            }

            return size;
        }
    }
}
