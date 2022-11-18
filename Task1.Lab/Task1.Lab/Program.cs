using System;
using System.Collections.Generic;

namespace Task1.Lab
{
    class Program
    {
        public delegate T Check< T>(double price);
        static void Main(string[] args)
         
        {
            Console.WriteLine("1.Show all products");
            Console.WriteLine("2.Show Add products");
            Console.WriteLine("3.Remove products");
            List<Product> products = new List<Product>();
            Product product1 = new Product("Iphone", 1000, true);
            Product product2 = new Product("Nokia", 300, false);
            Product product3 = new Product("Samsung", 3000, false);
            Product product4 = new Product("Asus", 2000, true);
            int num = int.Parse(Console.ReadLine());
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);

            if (num == 1)
            {
               GetProduct(products, CheckPrice, GetDiscount);
            }
            else if (num == 2)
            {
                Console.WriteLine("Enter new product's name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter new product's price");
                double price = double.Parse(Console.ReadLine());
                Product product = new Product(name, price, true);
                products.Add(product);

                GetProduct(products, CheckPrice, GetDiscount);

            }
            else if (num == 3)
            {
                Console.WriteLine("elimizde olanlar");
                GetProduct(products, CheckPrice, GetDiscount);
                Console.WriteLine("silmek istediyin mehsulun adini daxil edin");
                string name = Console.ReadLine();
                foreach (var item in products)
                {
                    if (item.Name==name)
                    {
                        item.isDeleted = true;

                    }
                }
                GetProduct(products, CheckPrice, GetDiscount);

            }
            else
            {
                Console.WriteLine("Bele mehsul yoxdur");
            }
        }
        public static bool CheckPrice(double price)
        {
            return price > 500;
        }
        public static double GetDiscount(double price)
        {
            return price * 0.7;
        }
        public static void GetProduct(List<Product> list,Check<bool> checkprice,Check<double> discountprice)
        {
            foreach (var item in list)
            {
                if (!item.isDeleted)
                {
                    if (checkprice(item.Price))
                    {
                        Console.WriteLine($"{item.Name} {discountprice(item.Price)} endirimli");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Name}  {item.Price}");
                    }
                }
               
              

            }
        }
       
    }
}
