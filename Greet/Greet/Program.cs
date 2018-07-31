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
            Console.WriteLine(Count());
            Console.ReadLine();
        }

        private static string Greet()
        {
            return "Hello Andrew!";
        }

        private static string Count()
        {
            return "I'm 145618668 years old! :/";
        }

        private static string Cheer()
        {
            return "G$tDrEaMtEaM";
        }
    }
}
