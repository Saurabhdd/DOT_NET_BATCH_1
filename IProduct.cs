using System;
namespace AllinOne
{
    public interface IProduct
    {
        string GetProductDetails();
        double GetProductPrice();

         public abstract string GetProductInfo();
    }
}