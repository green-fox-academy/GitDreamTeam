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
            Console.WriteLine(Greet("Yolo"));
            Console.WriteLine(Count(451245));
            Console.WriteLine(Cheer("C# <3 dzgfskmlhéíernjk", "valami"));
            Console.WriteLine(Future("virgin", 30, "Ez szomoru"));
            Console.ReadLine();
        }

        private static string Greet(string something)
        {
            return "Greetings for" + something;
        }

        private static string Count(int age)
        {
            return age + " 6";
        }

        private static string Cheer(string language, string teamName)
        {
            return language + " " + teamName;
        }
        private static string Future(string horoscope, int age, string input)
        {
            return "My horoscope is " + horoscope + " and my age is " + age + input;
        }
    }
}
