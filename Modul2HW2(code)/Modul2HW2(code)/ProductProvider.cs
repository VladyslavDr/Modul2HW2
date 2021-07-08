using System;

public class ProductProvider
{
    private static readonly Product[] _products;

    static ProductProvider()
    {
        _products = new Product[]
        {
            new Product { Name = "T-shirt", Price = new Priсe { Value = 125.5, Currency = CurrencyCode.UAH }, Id = 12354 },
            new Product { Name = "trousers", Price = new Priсe { Value = 58.03, Currency = CurrencyCode.UAH }, Id = 46540 },
            new Product { Name = "sneakers", Price = new Priсe { Value = 1941.99, Currency = CurrencyCode.UAH }, Id = 12321 },
            new Product { Name = "shirt", Price = new Priсe { Value = 8325.0, Currency = CurrencyCode.UAH }, Id = 96002 },
            new Product { Name = "shoes", Price = new Priсe { Value = 111.11, Currency = CurrencyCode.UAH }, Id = 16589 },
            new Product { Name = "cap", Price = new Priсe { Value = 635.93, Currency = CurrencyCode.UAH }, Id = 90009 },
            new Product { Name = "tie", Price = new Priсe { Value = 9898.11, Currency = CurrencyCode.UAH }, Id = 89635 },
            new Product { Name = "jacket", Price = new Priсe { Value = 2.01, Currency = CurrencyCode.UAH }, Id = 65465 },
            new Product { Name = "underpants", Price = new Priсe { Value = 36.98, Currency = CurrencyCode.UAH }, Id = 11111 },
            new Product { Name = "blouse", Price = new Priсe { Value = 828.199, Currency = CurrencyCode.UAH }, Id = 66996 },
            new Product { Name = "glasses", Price = new Priсe { Value = 4456.85, Currency = CurrencyCode.UAH }, Id = 14578 },
            new Product { Name = "gloves", Price = new Priсe { Value = 655.75, Currency = CurrencyCode.UAH }, Id = 96999 },
            new Product { Name = "skirt", Price = new Priсe { Value = 963.25, Currency = CurrencyCode.UAH }, Id = 65847 },
            new Product { Name = "backpack", Price = new Priсe { Value = 698.88, Currency = CurrencyCode.UAH }, Id = 87445 },
        };
    }

    public static Product[] GetArrayProducts()
    {
        return _products;
    }
}