﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMin();
        }

        static void GetMin()
        {
           var num1 = int.Parse(Console.ReadLine());
           var num2 = int.Parse(Console.ReadLine());
           var  num3 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine(num3);
                }
            }
            else
            {
                if (num2 < num3)
                {
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine(num3);
                }
            }
        }
    }
}
