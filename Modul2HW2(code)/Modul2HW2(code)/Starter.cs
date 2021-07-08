using System;

public class Starter
{
    public static void Run()
    {
        var products = ProductProvider.GetArrayProducts();
        var basket = Basket.Instance;

        basket.Add(products[0]);
        basket.Add(products[3]);
        basket.Add(products[4]);
        basket.Add(products[5]);
        basket.Add(products[8]);
        basket.Add(products[9]);
    }
}