using System;

public class Product
{
    public String name;
    public int cost;

    public String Name { get; set; }
    public int Cost { get; set; }

    public Product(String sname, int scost)
	{
        Name = sname;
        Cost = scost;
	}
}
