using System;

namespace dz4
{
    class Program
    {

        public static void print(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("{0} ", i);
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Please, enter two numbers: ");
            int.TryParse(Console.ReadLine(), out (a));
            int.TryParse(Console.ReadLine(), out (b));

            Console.WriteLine();
            if (a > b)
                print(b, a);
            else
                print(a, b);


            Console.ReadLine();
        }
    }
}
