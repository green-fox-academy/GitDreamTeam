﻿using System;
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
            Console.WriteLine(Cheer("csharpka"));
            Console.WriteLine(Future("virgin"));
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

        private static string Cheer(string language, string teamName)
        {
            return language + " " + teamName;
        }
        private static string Future(string horoscope)
        {
            return horoscope;
        }
    }
}
