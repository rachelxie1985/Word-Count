using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWorldCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a paragraph here (no numbers): ");
            var para = Console.ReadLine();
            Console.WriteLine("{0}", para);
            Console.ReadKey();
        }
    }
}
