using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    partial class SmartPhone
    {
        partial void printCharacteristicks()
        {
            Console.WriteLine("{0} characteristics:", type);
            Console.WriteLine("Brand: {0}", brand);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("RAM: {0} GB", ram);
            Console.WriteLine("Internal memory: {0} GB", memory);
            Console.WriteLine("Operating system: {0}", op);
        }
    }
}
