using System;
namespace AllinOne
{
    public abstract class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public Product(string name, string category, double price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        public abstract string GetProductInfo();
    }
}