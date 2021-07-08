using System;

public class Basket
{
    // private Product[] _products = new Product[MaxSize];
    private int _i;
    private static int _size = 10;
    private Basket()
    {
    }

    public static Basket Instance => new Basket();
    public Product[] Products { get; set; } = new Product[_size];
    public User User { get; set; } = UserService.Instance.GetCurrentUser();

    public void Add(Product product)
    {
        if (_i < ConfigService.Instance.BasketConfig.MaxSize)
        {
            Products[_i++] = product;
        }
        else
        {
            Console.WriteLine("Корзина расчитана на 10 продуктов!");
        }
    }
}