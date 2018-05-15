using System;

namespace dz3
{
    class Program
    {

        public static string convertUp(string s)
        {
            char[] tmp = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (tmp[i] >= 97 && tmp[i] <= 122)
                    tmp[i] -= (char)32;
            }

            return new string(tmp);
        }

        public static string convertLow(string s)
        {
            char[] tmp = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (tmp[i] >= 65 && tmp[i] <= 90)
                    tmp[i] += (char)32;
            }

            return new string(tmp);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string:");
            string s = Console.ReadLine();

            s = convertUp(s);
            Console.WriteLine("To upper case: " + s);

            s = convertLow(s);
            Console.WriteLine("To lower case: " + s);

            Console.ReadLine();
        }
    }
}
