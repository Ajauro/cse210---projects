using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        this._products = new List<Product>();
        this._customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        totalCost += GetShippingCost();
        return totalCost;
    }

    public double GetShippingCost()
    {
        return _customer.LocalUSA() ? 5 : 35;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $">>> {product.GetName()} (ID: {product.GetProductId()})\n";

            label += $"Unit Price: ${product.GetPrice()} | Quantity: {product.GetQuantity()}\n";

        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer Name: {_customer.GetName()}\nAddress: {_customer.GetAddress()}";
    }
}