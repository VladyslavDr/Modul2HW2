using System;

public class Basket
{
    private const int MaxSize = 10;
    private Product[] _products = new Product[MaxSize];
    private int _i;

    private Basket()
    {
    }

    public static Basket Instance => new Basket();

    public void Add(Product product)
    {
        if (_i < MaxSize)
        {
            _products[_i++] = product;
        }
        else
        {
            Console.WriteLine("Корзина расчитана на 10 продуктов!");
        }
    }
}