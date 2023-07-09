using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateAndEvents._1._06._2023
{
    public class Item : IComparable<Item>
    {
        public int Price { get; set; }
        public string Name { get; set; }


        public Item(int price, string name)
        {
            Price = price;
            Name = name;
        }   
        public Item()
        {
            Price = 0;
            Name = string.Empty;
        }

        public override string ToString()
        {
            return $"Name: {Name}\t Price: {Price}";
        }

        public int CompareTo(Item? other)
        {
            if(other != null)
                return Name.CompareTo(other.Name);

            return -1;
        }
    }
}
