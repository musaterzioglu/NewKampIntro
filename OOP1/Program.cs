﻿using System;


namespace OOP1
{
    class Program
    {
        static void Main(string[] args) 
        {
            Product product1= new Product();
            product1.Id= 1;
            product1.CategoryId = 2;
            product1.ProductName = "Dolap";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 10;

            Product product2 = new Product { Id = 1, CategoryId = 3, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 350 };

            //PascalCase  /camelCase
            //case sensitive

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            productManager.Topla2(3, 6);
            int toplamaSonucu = productManager.Topla(3, 6);

            Console.WriteLine(toplamaSonucu*2);
        }
    }
}
