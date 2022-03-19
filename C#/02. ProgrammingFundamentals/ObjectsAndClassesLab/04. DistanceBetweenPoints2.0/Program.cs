﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPoints2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPointParts = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToList();

            var secondPointParts = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToList();
          
            var firstPoint = new Point
            {
                X = firstPointParts[0], Y = firstPointParts[1]
            };

            var secondPoint = new Point
            {
                X = secondPointParts[0], Y = secondPointParts[1]
            };

            var result = Distance(firstPoint, secondPoint);
            Console.WriteLine("{0:f3}", result);
        }

        public static double Distance(Point first, Point second)
        {
            var squareX = Math.Pow(first.X - second.X, 2); 
            var squareY = Math.Pow(first.Y - second.Y, 2);
            var result = Math.Sqrt(squareX + squareY);

            return result;
        }
    }
}
