﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

                                  
            var area = a * h / 2.0;
            double areaRound = Math.Round(area, 2);

            Console.Write("Triangle_Area = " + areaRound);
         
            
        }
    }
}
