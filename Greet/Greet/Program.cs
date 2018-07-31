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
            Console.WriteLine(Count(451245));
            Console.WriteLine(Cheer("C# <3"));
            Console.WriteLine(Future("virgin"));
            Console.ReadLine();
        }

        private static string Greet(string name)
        {
            return name;
        }

        private static string Count(int age)
        {
            return age + " 5";
        }

        private static string Cheer(string language)
        {
            return language;
        }
        private static string Future(string horoscope)
        {
            return horoscope;
        }
    }
}
