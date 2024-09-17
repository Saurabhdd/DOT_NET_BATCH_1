
//using System.Reflection.Emit;
//using System.Data;
//using Internal;
using System;
namespace AllinOne
{
    public class pageDisplay<T> where T : Product
    {
        private List<T> products = new List<T>();
        public void AddProduct(T product)
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.GetProductInfo());
                Console.WriteLine($"Price : {product.Price:C}");
                Console.WriteLine("---------------------------------");
            }
        }

        public void DisplayFilteredProducts(Func<T, bool> predicate)
        {
            var filteredProducts = products.Where(predicate);

            foreach (var product in filteredProducts)
            {
                Console.WriteLine(product.GetProductInfo());
                Console.WriteLine($"Price : {product.Price:C}");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}