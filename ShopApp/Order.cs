using System;

public class Order
{
    public Customer buyer;
    public String seller;
    public String product;
    public DateTime orderTime;

    public Customer Buyer { get; set; }
    public String Seller { get; set; }
    public String Product { get; set; }
    public DateTime OrderTime { get; set; }

    public Order(Customer br, String shp, string product, DateTime order)
    {
        Buyer = br;
        Seller = shp;
        Product = product;
        OrderTime = order;
    }
}
