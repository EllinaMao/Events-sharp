using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Item
    {
        public string Name { get; set; }
        public double Volume { get; set; }

        public Item()
        {
            Name = string.Empty;
            Volume = 0;
        }
        public Item(string name, double volume)
        {
            Name = name;
            Volume = volume;
        }

        public override string ToString()
        {
            return $"{Name}, объем: {Volume}";
        }

    }
}
