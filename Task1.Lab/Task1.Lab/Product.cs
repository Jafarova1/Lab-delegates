using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Lab
{
    public class Product
    {
      
        public string Name { get; set; }
        public double Price { get; set; }
        public bool isDeleted { get; set; }
        public Product(string name,double price,bool IsDeleted)
        {
            Name = name;
            Price = price;
            isDeleted = IsDeleted;
        }
    }
}
