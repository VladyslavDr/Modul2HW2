using System;

public class OrderService
{
    private int _counter;

    private OrderService()
    {
    }

    public static OrderService Instance => new OrderService();

    public Order CreateOrder(Basket basket)
    {
        var order = new Order { Products = CopyProductArray(basket.Products), AllPrice = GetAllPrice(basket.Products), Id = _counter++, User = basket.User };
        BasketService.Instance.ClearBusket(basket);
        return order;
    }

    private Product[] CopyProductArray(Product[] products)
    {
        var arrayCopy = new Product[products.Length];
        Array.Copy(products, arrayCopy, products.Length);

        return arrayCopy;
    }

    private double GetAllPrice(Product[] products)
    {
        var allPrice = 0.0;

        foreach (var product in products)
        {
            allPrice += product.Price.Value;
        }

        return allPrice;
    }
}