using System;

public class Starter
{
    public static void Run()
    {
        // заполнение корзинки
        var products = ProductProvider.GetArrayProducts();
        var basket = Basket.Instance;

        basket.Add(products[0]);
        basket.Add(products[2]);
        basket.Add(products[4]);
        basket.Add(products[4]);
        basket.Add(products[9]);
        basket.Add(products[5]);
        basket.Add(products[5]);
        basket.Add(products[4]);
        basket.Add(products[2]);
        basket.Add(products[0]);

        var num1 = new OrderService();
        OrderService.GetAllProducts(basket.Products);
        OrderService.GetAllPrice(basket.Products);
        OrderService.User();

        Console.Write("products: ");

        foreach (var i in ProductProvider.GetArrayProducts())
        {
            Console.Write($"{i.Name} ");
        }

        Console.WriteLine();
        Console.Write("choice products: ");

        foreach (var i in OrderService.GetAllProducts(basket.Products))
        {
            Console.Write($"{i.Name} ");
        }

        Console.WriteLine();
        Console.WriteLine($"All price: {OrderService.GetAllPrice(basket.Products)}");

        Notification.SmsToMail(OrderService.User());
    }
}