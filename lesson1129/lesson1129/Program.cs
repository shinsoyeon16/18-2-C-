using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1129
{
    class Program
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public Product(string a, int b)
            {
                Name = a; Price = b;
            }
            public override string ToString()
            {
                return "Name: " + Name + ", Price : " + Price;
            }
        }
        class Products
        {
            public List<Product> products = new List<Product>();
            public delegate void PrintProcess(Product p);
            public void Add(Product p)
            {
                products.Add(p);
            }
            public void Print()
            {
                foreach (var item in products)
                {
                    Console.WriteLine(item);
                }
                Print((p) =>
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("이름 : " + p.Name);                                                                                                                                                                                                                                                    
                    Console.WriteLine("가격 : " + p.Price);
                    Console.WriteLine("---------------------------");
                });
            }

            public void Print(PrintProcess process)
            {
                foreach (var item in products)
                {
                    process(item);
                }
            }
        }
        static void Main(string[] args)
        {
            Products products = new Products();
            products.Add(new Product("a", 100));
            products.Add(new Product("b", 200));
            products.Add(new Product("c", 300));
            products.Print();
        }

    }
}