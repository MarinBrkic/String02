﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace klasaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1;
            Console.WriteLine("Unesi neku recenicu: ");
            s1 = Console.ReadLine();

            Console.WriteLine(s1.Replace(" ", " - "));
           
            Console.ReadKey();
        }
    }
}
