using System;

public class BasketService
{
    private BasketService()
    {
    }

    public static BasketService Instance => new BasketService();

    public void ClearBusket(Basket basket)
    {
        for (var i = 0; i < basket.Products.Length; i++)
        {
            basket.Products[i] = null;
        }
    }
}
