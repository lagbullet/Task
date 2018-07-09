using System;
using System.Collections.Generic;

namespace ShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("Shop");
            shop.SetProduct("Milk", 100);
            shop.SetProduct("Water", 50);
            shop.SetProduct("Bread", 50);
            shop.SetProduct("Kefir", 150);
            shop.SetProduct("Ice cream", 200);
            shop.SetProduct("Cottage cheese", 160);
            shop.SetProduct("Cheese", 160);
            Customer customer = new Customer("Ivanov", "Ivan");
            shop.Show();
            Product[] ords= { new Product("Milk",100), new Product("Water", 50), new Product("Ice cream", 150) };
            customer.Order(shop, ords);
            Product[] ords1 = { new Product("Bread", 50), new Product("Cheese", 160), new Product("Cottage cheese", 160), new Product("Water", 50) };
            customer.Order(shop, ords1);
            customer.Show();
            Console.ReadLine();
        }
    }
}
