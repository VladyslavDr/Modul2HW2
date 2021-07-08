using System;

public class OrderService
{
    public Order Order { get; set; }

    public static Product[] GetAllProducts(Product[] products)
    {
        var order = new Product[products.Length];
        Array.Copy(products, order, products.Length);

        return order;
    }

    public static double GetAllPrice(Product[] products)
    {
        var allPrise = 0.0;

        foreach (var product in products)
        {
            allPrise += product.Price.Value;
        }

        return allPrise;
    }

    public static User User()
    {
        return new User { PhoneNumber = "+38066466426", Mail = "vladislav.Drushliak@gmail.com" };
    }
}