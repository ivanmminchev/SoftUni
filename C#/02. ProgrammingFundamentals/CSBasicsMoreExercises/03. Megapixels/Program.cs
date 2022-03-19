﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double mp = Math.Round(((width * height) / 1000000), 1);
            Console.WriteLine($"{width}x{height} => {mp}MP");
        }
    }
}
