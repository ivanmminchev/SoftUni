﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eiTuiNew
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};
            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(separators);
            var result = words
              .Where(w => w != "")
              .Where(w => w.Length < 5)
              // TODO: filter by word length < 5
              .OrderBy(w => w).Distinct();
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
