using System;
namespace AllinOne
{
    class Program
    {
        static void Main(string[] args)
        {
            CTable table1 = new CTable("Dining Table", "Furniture", 299.99, "Wood", 4);
            CTable table2 = new CTable("Coffee Table", "Furniture", 99.99, "Glass", 3);
            CTable table3 = new CTable("Study Table", "Furniture", 150.00, "Metal", 4);

            pageDisplay<CTable> tableDisplay = new pageDisplay<CTable>();

            tableDisplay.AddProduct(table1);
            tableDisplay.AddProduct(table2);
            tableDisplay.AddProduct(table3);

            Console.WriteLine("All Products:");
            tableDisplay.DisplayProducts();

            Console.WriteLine("Filtered Products (Price > 100):");
            tableDisplay.DisplayFilteredProducts(table => table.Price > 100);

            Console.WriteLine("Filtered Products (Material is Wood):");
            tableDisplay.DisplayFilteredProducts(table => table.Material == "Wood");
        }
    }
}