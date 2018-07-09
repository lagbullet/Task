using System;
using System.Collections.Generic;

public class Customer
{
    public String surName;
    public String firstName;
    public List<Order> orders = new List<Order>();


    public String SurName { get; set; }
    public String FirstName { get; set; }

    public Customer(String sname,String fname)
	{
        SurName = sname;
        FirstName = fname;
    }

    public void Order(Shop shop, Product[] pname)
    {
        int k=0;
        foreach(Product pr in shop.products)
        {
            if (pr == null) break;
            foreach (Product prod in pname)
                if (pr.ProductName.Equals(prod.ProductName))
                    k++;
        }
        if (k != pname.Length)
        {
            Console.WriteLine("There is no such product");
            return;
        }
        orders.Add(new Order(this, shop.shopName, pname, DateTime.Now));
    }

    public void Show()
    {
        Console.WriteLine("" + SurName + " " + FirstName + "\n  Orders  ");
        foreach (Order ord in orders)
        {
            //Console.WriteLine("Shop: "+ ord.Seller);
            Console.Write("Products:");
            foreach (Product pr in ord.prods)
                Console.Write(" " + pr.ProductName);
            Console.WriteLine("\nOrder Time: " + ord.OrderTime);
            Console.WriteLine();
        }
    }
}
