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

        var order = OrderService.Instance.CreateOrder(basket);
        Notification.SmsToPhoneNumber(order.User);
    }
}