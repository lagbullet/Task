using System;
using System.Collections.Generic;

public class Order
{
    public Customer buyer;
    public String seller;
    public List<String> prods = new List<String>();
    public DateTime orderTime;

    public Customer Buyer { get; set; }
    public String Seller { get; set; }
    public DateTime OrderTime { get; set; }

    public Order(Customer br, String shp, string[] prds, DateTime order)
    {
        Buyer = br;
        Seller = shp;
        foreach (String str in prds)
            prods.Add(str);
        OrderTime = order;
    }
}
