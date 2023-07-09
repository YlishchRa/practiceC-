using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelagateAndEvents._1._06._2023;
using System.Collections.Generic;
using System.Collections;

namespace DelagateAndEvents._1._06._2023
{
    public class Basket : IEnumerable
    {
        public Dictionary<Item,int> baket;
        public int totalAmount { get; set; }
        public Basket()
        {
            baket = new Dictionary<Item, int>();
            totalAmount = 0;
        }
        public void AddItem(Item item, int count)
        {

            if(baket.ContainsKey(item))
            {
                totalAmount -= (baket[item] * item.Price);

                baket.Remove(item);
                baket.Add(item, count);
            }
            else
            {
                baket.Add(item, count);
            }

            totalAmount += (count * item.Price);

        }

        public IEnumerator GetEnumerator()
        {
           return  baket.GetEnumerator();
        }

        public override string ToString()
        {
            string result = "";

            foreach(KeyValuePair<Item, int> item in baket)
            {
                result += item.Key.ToString() + $"\tCount: {item.Value}";
                result += "\n";
            }

            result += $"\n\nTotal price: \t {totalAmount}";

            return result;
        }

    }
}
