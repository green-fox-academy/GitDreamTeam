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
            Console.WriteLine(Greet("Andrew"));
            Console.WriteLine(Count(451245));
            Console.WriteLine(Future());
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
