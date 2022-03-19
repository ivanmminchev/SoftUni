﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = x => Console.WriteLine(x);

            var input = Console.ReadLine()
                .Split()
                .ToList();
            foreach (var item in input)
            {
                print(item);
            }
        }
    }
}
