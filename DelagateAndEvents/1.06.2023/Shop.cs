using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelagateAndEvents._1._06._2023;

namespace DelagateAndEvents._1._06._2023
{
    public class Shop
    {
        List<Item> itemsInShop;
        Basket basket;
        
        public Shop()
        {

            itemsInShop = new List<Item>();
            itemsInShop.Add(new Item(10, "Tomato"));
            itemsInShop.Add(new Item(25, "Pasta"));
            itemsInShop.Add(new Item(5, "Smetana"));
            itemsInShop.Add(new Item(15, "Ice cream"));
            itemsInShop.Add(new Item(20, "Chees"));
            itemsInShop.Add(new Item(30, "Ogirok"));
            basket = new Basket();


            for(int i = 0; i < itemsInShop.Count; i++)
            {
                Console.WriteLine($"{i} {itemsInShop[i]}");
            }
        }
        public void StartShoping()
        {
            int indexOfItem = 0;
            while(indexOfItem != -1)
            {
                indexOfItem = Convert.ToInt16(Console.ReadLine());
                if (indexOfItem == -1)
                    break;
                int count = Convert.ToInt16(Console.ReadLine());

                basket.AddItem(itemsInShop.ElementAt(indexOfItem), count);
            }


            Console.WriteLine(basket);
        }
    }
}
