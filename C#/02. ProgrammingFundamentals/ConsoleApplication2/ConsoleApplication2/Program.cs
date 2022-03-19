﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "+13230", "-0", "1,390,146", "$190,235,421,127",
                          "0xFA1B", "163042", "-10", "2147483647",
                          "2147483648", "16e07", "134985.0", "-12034",
                          "-2147483648", "-2147483649" };
            foreach (string value in values)
            {
                try
                {
                    int number = Int32.Parse(value);
                    Console.WriteLine("{0} --> {1}", value, number);
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0}: Bad Format", value);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("{0}: Overflow", value);
                }

            }
    }
}

/*using System;

public class Example
{
    public static void Main()
    {
        DateTime baseDate = new DateTime(2000, 2, 29);
        Console.WriteLine("    Base Date:        {0:d}\n", baseDate);

        // Show dates of previous fifteen years.
        for (int ctr = -1; ctr >= -15; ctr--)
            Console.WriteLine("{0,2} year(s) ago:        {1:d}",
                              Math.Abs(ctr), baseDate.AddYears(ctr));
        Console.WriteLine();

        // Show dates of next fifteen years.
        for (int ctr = 1; ctr <= 15; ctr++)
            Console.WriteLine("{0,2} year(s) from now:   {1:d}",
                              ctr, baseDate.AddYears(ctr));
    }
}
*/