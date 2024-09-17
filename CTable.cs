//using System.Collections.Concurrent;
using System;
namespace AllinOne
{
    public class CTable : Product, IProduct
    {
        public string Material { get; set; }
        public int NumberOfLegs { get; set; }

        public CTable(string name, string category, double price, string material, int numberOfLegs)
            : base(name, category, price)
        {
            Material = material;
            NumberOfLegs = numberOfLegs;
        }    

        public override string GetProductInfo()
        {
            return $"Name : {Name}, Category :  {Category}, Price : {Price:C}, Material : {Material}, Number Of Legs : {NumberOfLegs}";
        }

        public string GetProductDetails()
        {
            return $"Table : {Name}, Material : {Material}, Legs : {NumberOfLegs}";           
        }
        public double GetProductPrice()
        {
            return Price;
        }
        
    }
}