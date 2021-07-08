using System;
public class ConfigService
{
    private Config _config;
    private ConfigService()
    {
        _config = new Config { Basket = new BasketConfig { MaxSize = 10 } };
    }

    public BasketConfig BasketConfig => _config.Basket;
    public static ConfigService Instance => new ConfigService();
}