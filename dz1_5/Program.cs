using System;

namespace dz5
{
    class Program
    {
        public static string reverse(string s)
        {
            char[] c = s.ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter some number:");
            int.TryParse(Console.ReadLine(), out (n));
            string s = n.ToString();

            int.TryParse(reverse(s), out (n));
            Console.WriteLine(n);

            Console.ReadLine();
        }
    }
}
