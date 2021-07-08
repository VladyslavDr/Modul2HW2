using System;

public class Order
{
    public double AllPrice { get; set; }
    public int Id { get; set; }
    public Product[] Products { get; set; }
    public User User { get; set; }
}
