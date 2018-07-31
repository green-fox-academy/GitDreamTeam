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
            Console.WriteLine(Greet("Andrew"));
            Console.WriteLine(Count());
            Console.WriteLine(Future());
            Console.ReadLine();
        }

        private static string Greet(string name)
        {
            return name;
        }

        private static string Count()
        {
            return "I'm 145618668 years old! :/";
        }

        private static string Cheer()
        {
            return "G$tDrEaMtEaM";
        }
        private static string Future()
        {
            return "I am a virgin.";
        }
    }
}
