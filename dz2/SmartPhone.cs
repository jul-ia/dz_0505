using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    partial class SmartPhone
    {
        static string type;
        string brand;
        string name;
        int ram;
        int memory;
        string op;
        int sdCard;

        static SmartPhone()
        {
            type = "Smatphone";
        }

        public SmartPhone()
        {
            brand = "Unknown";
            name = "SmartPhone";
            ram = 1;
            memory = 0;
            op = "OP";
            sdCard = 0;
        }

        public SmartPhone(string brand)
        {
            this.brand = brand;
        }
        public SmartPhone(string brand, string name) : this(brand)
        {
            this.name = name;
        }
        public SmartPhone(string brand, string name, int ram) : this(brand, name)
        {
            this.ram = ram;
        }
        public SmartPhone(string brand, string name, int ram, int memory) : this(brand, name, ram)
        {
            this.memory = memory;
        }
        public SmartPhone(string brand, string name, int ram, int memory, string op) : this(brand, name, ram, memory)
        {
            this.op = op;
        }
        public SmartPhone(string brand, string name, int ram, int memory, string op, int sd) : this(brand, name, ram, memory, op)
        {
            this.sdCard = sd;
        }

        public string Brand
        {
            set { brand = value; }
            get { return brand; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int RAM
        {
            set { ram = value; }
            get { return ram; }
        }
        public int Memory
        {
            set { memory = value; }
            get { return memory; }
        }
        public string OP
        {
            set { op = value; }
            get { return op; }
        }
        public int SDCard
        {
            set { sdCard = value; }
            get { return sdCard; }
        }


        public double approximatePrice()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            double p = 200;
            p += ram / 0.6 + memory / 0.75 + rand.Next(50, 100)*0.1;
            return p;
        } 

        public void getTotalMemory(out int m)
        {
            m = memory + sdCard;
        }

        partial void printCharacteristicks();

        public void print()
        {
            this.printCharacteristicks();        
        }
    }
}
