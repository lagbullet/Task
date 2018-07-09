using System;
using System.Collections.Generic;

public class Order
{
    public Customer buyer;
    public String seller;
    public List<Product> prods = new List<Product>();
    public DateTime orderTime;

    public Customer Buyer { get; set; }
    public String Seller { get; set; }
    public DateTime OrderTime { get; set; }

    public Order(Customer br, String shp, Product[] prds, DateTime order)
    {
        Buyer = br;
        Seller = shp;
        foreach (Product str in prds)
            prods.Add(str);
        OrderTime = order;
    }
}
