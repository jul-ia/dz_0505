using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of your ticket:");
            int n;
            int.TryParse(Console.ReadLine(), out (n));

            string s = n.ToString();
            int s1 = 0, s2 = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int.TryParse(s[i].ToString(), out (n));
                if (i < s.Length / 2)
                    s1 += n;
                else
                    s2 += n;
            }

            if (s1 == s2)
                Console.WriteLine("You`ve got a lucky ticket!");
            else
                Console.WriteLine("Just a ticket");


            Console.ReadLine();
        }
    }
}
