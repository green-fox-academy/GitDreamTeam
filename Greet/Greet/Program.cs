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
            Console.WriteLine(Greet("Welcome"));
            Console.WriteLine(Count(451245));
            Console.WriteLine(Cheer("Cheer"));
            Console.WriteLine(Future("virgin", 30));
            Console.ReadLine();
        }

        private static string Greet(string greetings)
        {
            return greetings;
        }

        private static string Count(int age)
        {
            return age + " 5";
        }

        private static string Cheer(string cheering)
        {
            return cheering;
        }
        private static string Future(string horoscope, int age)
        {
            return "My horoscope is " + horoscope + " and my age is " + age;
        }
    }
}
