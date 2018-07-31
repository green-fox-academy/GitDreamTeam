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
            Console.WriteLine(Future("virgin"));
            Console.ReadLine();
        }

        private static string Greet(string name)
        {
            return name;
        }

        private static int Count(int age)
        {
            return age;
        }

        private static string Cheer(string teamName)
        {
            return teamName;
        }
        private static string Future(string horoscope)
        {
            return horoscope;
        }
    }
}
