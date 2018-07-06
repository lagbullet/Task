using System;

public class Customer
{
    public String surName;
    public String firstName;
    public Order[] orders;
    public int ocount = 0;


    public String SurName { get; set; }
    public String FirstName { get; set; }

    public Customer(String sname,String fname)
	{
        SurName = sname;
        FirstName = fname;
        orders = new Order[5];
    }

    public void Order(Shop shop, String pname)
    {
        int k=0;
        foreach(Product pr in shop.products)
        {
            if (pr == null) break;
            if (pr.Name.Equals(pname))
            {
                k = 1; 
                break;
            }
        }
        if (k == 0)
        {
            Console.WriteLine("There is no such product");
            return;
        }
        if (ocount < orders.Length)
            orders[ocount++] = new Order(this, shop.Name, pname, DateTime.Now);
        else
        {
            Array.Resize(ref orders, ocount + 5);
            orders[ocount++] = new Order(this, shop.Name, pname, DateTime.Now);
        }
    }

    public void Show()
    {
        Console.WriteLine("" + SurName + " " + FirstName+ "\n  Orders  ");
        for (int i = 0; i < ocount; i++)
            Console.WriteLine("Product: " + orders[i].Product + "; Order Time: " + orders[i].OrderTime);
    }
}
