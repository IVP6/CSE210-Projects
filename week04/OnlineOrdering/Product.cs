using System.Collections.Generic;

class Product
{
    public int _ID;
    public string _name;
    public double _price;
    public int _quantity;

    // Static list of all available products
    public static List<Product> products = new List<Product>
    {
        new Product(1406, "Precept Chips", 2.99, 1),
        new Product(1407, "L.U.L Popcorn", 4.50, 1),
        new Product(1405, "Liahona Burger Patties", 8.99, 1),
        new Product(3579, "Celsius Energy Drink", 2.49, 1),
        new Product(3580, "Monster Energy Drink", 3.19, 1)
    };

    public Product(int id, string name, double price, int quantity)
    {
        _ID = id;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    // Required methods for Order class
    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _ID.ToString();
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}