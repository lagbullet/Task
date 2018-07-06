using System;

public class Shop
{
    public String name;
    public Product[] products = new Product[20];
    int pcount = 0;

    public Shop(String sname)
    {
        Name = sname;
    }

    public String Name { get; set; }
    public void SetProduct(String pname, int pcost)
    {
        if (pcount < products.Length)
            products[pcount++] = new Product(pname, pcost);
        else
        {
            Array.Resize(ref products, pcount + 20);
            products[pcount++] = new Product(pname, pcost);
        }
    }

    public void Show()
    {
        Console.Write("Shop name -> " + Name);
        Console.WriteLine("\n  Products  ");
        for (int i = 0; i < pcount; i++)
            Console.WriteLine("Product: " + products[i].Name+ "; Cost: " + products[i].Cost);
    }
}
