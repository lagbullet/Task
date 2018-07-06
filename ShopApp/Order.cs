using System;

public class Order
{
    public Customer buyer;
    public String seller;
    public String[] prods;
    public DateTime orderTime;

    public Customer Buyer { get; set; }
    public String Seller { get; set; }
    public String[] Prods { get; set; }
    public DateTime OrderTime { get; set; }

    public Order(Customer br, String shp, string[] prds,int pcount, DateTime order)
    {
        Buyer = br;
        Seller = shp;
        Prods = new String[pcount];
        for (int i=0; i<pcount; i++)
            Prods[i] = prds[i];
        OrderTime = order;
    }
}
