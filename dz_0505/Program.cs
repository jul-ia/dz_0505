﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_0505
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            char c;
            do
            {
                c = Console.ReadKey().KeyChar;
                if (c == ' ')
                    count++;
            } while (c != '.');

            Console.WriteLine("\nSpaces: {0}", count);

            Console.ReadLine();
        }
    }
}
