using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateAndEvents._12._05._2023
{

    public interface ICart
    {
        int Count();
    }
    public class Cart : ICart
    {
        public List<IProduct> Products { get; set; }

        public Cart()
        {
            Products = new List<IProduct>();
        }
        public int Count()
        {
            int rezilt = 0;
            foreach (var item in Products)
            {
                rezilt++;
            }
            return rezilt;
        }

        public void Add(IProduct product)
        {
            Products.Add(product);

        }


        public void Show()
        {
            foreach(var item in Products)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("\n----------------------\n");
            }
        }
    }



    public interface IProduct
    {
        string Name { get; set; }
        float price { get; set; }
        int count { get; set; }
        public void InputData();
        public string ToString();
    }

    public class Product : IProduct
    {
        public string Name { get; set; }
        public float price { get; set; }
        public int count { get; set; }

        public void InputData()
        {
            Console.WriteLine("Enter name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter price: ");
            price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter count: ");
            count = Convert.ToInt32(Console.ReadLine());
        }


        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {price}\nCount:{count}\n";
        }

    }
//    Cart c = new Cart();


//    c.Add(new Product());
//c.Add(new Product());
//c.Add(new Product());


//foreach (var item in c.Products)
//{
//    item.InputData();
//}

//foreach (var item in c.Products)
//{
//    Console.WriteLine(item.ToString());
//} 
// Put it to program.cs file
}
