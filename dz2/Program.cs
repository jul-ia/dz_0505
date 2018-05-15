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
            SmartPhone[] phones = new SmartPhone[5] {
                new SmartPhone("Samsung", "Galaxy S7 G930A ", 4, 32, "Android 6.0", 1),
                new SmartPhone("Huawei", "P10 Lite", 3, 32, "Android 7.0", 2),
                new SmartPhone("Xiaomi", "Mi A1", 4, 32, "Android One", 1),
                new SmartPhone("Samsung", "Galaxy J7 Pro", 3, 32, "Android 7.0", 2),
                new SmartPhone(),
            };

            foreach(SmartPhone p in phones)
            {
                p.print();
                int i;
                p.getTotalMemory(out i);
                Console.WriteLine("Total memory: {0}", i);
                Console.WriteLine("Approximate price: {0:N}$", p.approximatePrice());
                Console.WriteLine(new string('-', 30));
            }

            Console.ReadLine();
        }
    }
}
