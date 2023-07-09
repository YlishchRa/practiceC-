using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateAndEvents._19._05._2023
{
    public  class Product
    {
        public delegate void Action(Product a);
        public delegate float Func(Product a);
        public delegate void Predicate(Product a);
        public bool greater { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        
        public Product(string name_, int price_,int quantity_)
        {
            this.name = name_;
            this.price = price_;
            this.quantity = quantity_;
        }
        
        public Product()
        {

        }

        public void Show(Action a)
        {
            a(this);
        }
        public float TotalPrice(Func a)
        {
            return a(this);
        }

        public void Pred(Predicate a)
        {
            a(this);
        }
        // PUT IT  INTO MAIN FILE 
        //        void swap<T>(ref T a, ref T b)
        //        {
        //            T temp = a;
        //            a = b;
        //            b = temp;
        //        }
        //        void Show(DelagateAndEvents._19._05._2023.Product a)
        //        {
        //            Console.WriteLine($"Name: {a.name}\nPrice: {a.price}\nQuantity: {a.quantity}\n");
        //        }
        //        float TotalPrice(DelagateAndEvents._19._05._2023.Product a)
        //        {
        //            return a.price * a.quantity;
        //        }
        //        void Predicate(DelagateAndEvents._19._05._2023.Product a)
        //        {
        //            a.greater = a.price > 500;
        //        }
        //        void Compresion(ref List<DelagateAndEvents._19._05._2023.Product> l)
        //        {
        //            for (int i = 0; i < l.Count; i++)
        //            {
        //                for (int j = l.Count - 1; j > i; j--)
        //                {
        //                    if (l[j].name[0] > l[j - 1].name[0])
        //                    {
        //                        string tmp = l[j].name;
        //                        l[j].name = l[j - 1].name;
        //                        l[j - 1].name = tmp;
        //                    }
        //                }
        //            }

        //            for (int i = 0; i < l.Count; i++)
        //            {
        //                for (int j = l.Count - 1; j > i; j--)
        //                {
        //                    if (l[j].price > l[j - 1].price)
        //                    {
        //                        int tmp = l[j].price;
        //                        l[j].price = l[j - 1].price;
        //                        l[j - 1].price = tmp;
        //                    }
        //                }
        //            }

        //            for (int i = 0; i < l.Count; i++)
        //            {
        //                for (int j = l.Count - 1; j > i; j--)
        //                {
        //                    if (l[j].quantity > l[j - 1].quantity)
        //                    {
        //                        int tmp = l[j].quantity;
        //                        l[j].quantity = l[j - 1].quantity;
        //                        l[j - 1].quantity = tmp;
        //                    }
        //                }
        //            }
        //        }


        //        List<DelagateAndEvents._19._05._2023.Product> a = new List<DelagateAndEvents._19._05._2023.Product>();


        //        a.Add(new DelagateAndEvents._19._05._2023.Product("Pomdor", 150, 5));
        //a.Add(new DelagateAndEvents._19._05._2023.Product("Tomat", 50, 70));
        //a.Add(new DelagateAndEvents._19._05._2023.Product("Potato", 3, 2300));
        //a.Add(new DelagateAndEvents._19._05._2023.Product("Chiken", 150, 150));
        //Compresion(ref a);

        //foreach (var item in a)
        //{
        //    item.Pred(Predicate);
        //    item.Show(Show);
        //}


    }
}
