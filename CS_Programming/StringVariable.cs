﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringVariable
{
    internal class Program
    {
        static void Main(string[] args) {

            string message = "안녕하세요";

            Console.WriteLine(message + "!");
            Console.WriteLine(message[0]);
            Console.WriteLine(message[1]);
            Console.WriteLine(message[2]);

            Console.WriteLine("------------------------");

            bool one = 10 < 0;
            bool other = 20 > 100;

            Console.WriteLine(one);
            Console.WriteLine(other);

            Console.WriteLine("------------------------");
        }
    }
}
