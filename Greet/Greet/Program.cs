using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Greet());
            Console.ReadLine();
        }

        private static string Greet()
        {
            return "Hello Andrew!";
        }
    }
}
