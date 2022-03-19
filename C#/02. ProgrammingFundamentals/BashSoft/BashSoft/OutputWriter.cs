﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public static class OutputWriter
    {

        public static void WriteMessage(string message)
        {
            Console.WriteLine("message");
        }
        public static void WriteMessageOnNewLine(string message)
        {
            Console.Write("message");
            Console.WriteLine();
        }
        public static void WriteEmptyLine(string message)
        {
            Console.WriteLine();
        }
        public static void DisplayExeption(string message)
        {
            ConsoleColor currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = currentColor;
        }
    }

}


