﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Power_Plants
{
    using System;
    using System.Linq;

    public class PowerPlants
    {
        public static void Main()
        {
            var powerLevel = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var len = powerLevel.Length;
            var season = 0;
            var day = 0;

            while (powerLevel.Max() >= 0)
            {
                for (int days = 0; days < len; days++)
                {
                    for (int bloom = 0; bloom < len; bloom++)
                    {
                        if (days != bloom && powerLevel[bloom] > 0)
                        {
                            powerLevel[bloom]--;
                        }
                    }
                    day++;
                    if (powerLevel.Max() == 0)
                    {
                        break;
                    }
                }
                if (powerLevel.Max() == 0)
                {
                    break;
                }
                for (int seasonEnd = 0; seasonEnd < len; seasonEnd++)
                {
                    if (powerLevel[seasonEnd] > 0)
                    {
                        powerLevel[seasonEnd]++;
                    }
                }
                season++;
            }
            Console.WriteLine($"survived {day} days ({season} seasons)");
        }
    }
}