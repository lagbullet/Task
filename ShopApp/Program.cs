using System;

namespace ShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("SHOP");
            shop.SetProduct("pr1", 100);
            Customer customer = new Customer("Surname1", "Firstname1");
            shop.Show();
            customer.Order(shop, "pr1");
            customer.Show();
            Console.ReadLine();
        }
    }
}
