using System;
using System.Collections.Generic;

public class Shop
{
    public String shopName;
    public List<Product> products = new List<Product>();

    public Shop(String sname) => shopName = sname;

    public void SetProduct(String pname, int pcost)
    {
        products.Add(new Product(pname, pcost));
    }

    public void Show()
    {
        Console.Write("Shop name -> " + shopName);
        Console.WriteLine("\n  Products  ");
        foreach (Product pr in products)
            pr.Show();
    }
}
