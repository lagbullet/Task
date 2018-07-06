using System;

public class Product
{
    public String productName;
    public int cost;

    public String ProductName { get; set; }
    public int Cost { get; set; }

    public Product(String sname, int scost)
	{
        ProductName = sname;
        Cost = scost;
	}

    public void Show() => Console.WriteLine("Product: " + ProductName + "; Cost: " + Cost);

}
