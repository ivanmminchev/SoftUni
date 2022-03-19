﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.DebuggingExerciseTrickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());            
            var result = string.Empty;
            var currentString = string.Empty;

            for (int i = 0; i < numberOfStrings; i++)
            {
                currentString += Console.ReadLine();
                if (i < numberOfStrings - 1)
                {
                    currentString = currentString + delimiter;
                }              
            }

            Console.WriteLine(currentString);
        }
    }
}