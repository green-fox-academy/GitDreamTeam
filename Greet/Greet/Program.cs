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
            Console.WriteLine(Greet("Welcome", "Yolo"));
            Console.WriteLine(Count(451245));
<<<<<<< HEAD
            Console.WriteLine(Cheer("Cheer"));
=======
<<<<<<< HEAD
            Console.WriteLine(Cheer("C# <3 dzgfskmlhéíernjk"));
>>>>>>> master
            Console.WriteLine(Future("virgin", 30));
=======
            Console.WriteLine(Cheer("csharpka"));
            Console.WriteLine(Future("virgin"));
>>>>>>> 61b6b332b502ac948014ce62c160b90832fa965e
            Console.ReadLine();
        }

        private static string Greet(string greetings, string something)
        {
            return greetings + something;
        }

        private static string Count(int age)
        {
            return age + " 6";
        }

<<<<<<< HEAD
        private static string Cheer(string cheering)
        {
            return cheering;
=======
        private static string Cheer(string language, string teamName)
        {
            return language + " " + teamName;
>>>>>>> master
        }
        private static string Future(string horoscope, int age)
        {
            return "My horoscope is " + horoscope + " and my age is " + age;
        }
    }
}
