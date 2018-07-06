using System;
using System.Collections.Generic;

namespace ShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("SHOP");
            shop.SetProduct("Product1", 100);
            shop.SetProduct("Product2", 50);
            Customer customer = new Customer("Surname1", "Firstname1");
            shop.Show();
            String[] ords = { "Product1", "Product2", "Product1", "Product1" };
            customer.Order(shop, ords);
            customer.Order(shop, ords);
            customer.Show();
            Console.ReadLine();
        }
    }
}
