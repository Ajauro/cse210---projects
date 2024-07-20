using System;

public class Product
{
    private string _name;
    private int _productID;
    private double _price; //dollars
    private int _quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        this._name = name;
        this._productID = productId;
        this._price = price;
        this._quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetProductId()
    {
        return _productID;
    }

    public double GetPrice()
    {
        return _price;
    }
}