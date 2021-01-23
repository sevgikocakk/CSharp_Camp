using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 5;

            Product product2 = new Product { Id=2, CategoryId= 3, ProductName="Kalem", UnitPrice=7,UnitInStock= 35};

            //PascalCase   camelCase 
            //case sensitive 
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            
        }
    }
}
