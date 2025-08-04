using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _shoppingCart;
    private Customer _customer;
    private Address _address;
    
    // Constructor that takes customer and address objects
    public Order(Customer customer, Address address)
    {
        _shoppingCart = new List<Product>();
        _customer = customer;
        _address = address;
    }

    // Add product to shopping cart
    public void AddProduct(Product product)
    {
        if (product != null)
        {
            _shoppingCart.Add(product);
        }
    }

    // Add multiple products from a list
    public void AddProducts(List<Product> products)
    {
        foreach (Product product in products)
        {
            AddProduct(product);
        }
    }

    // Calculate total price of order including shipping
    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (Product product in _shoppingCart)
        {
            total += product.GetTotalCost(); // price * quantity
        }
        return total + _address.GetShippingCost();
    }

    // Return string for packing label
    public string GetPackingLabel()
    {
        string label = "=== PACKING LABEL ===\n";
        label += $"Customer: {_customer.GetCustomerName()}\n\n";
        label += "Items to Pack:\n";
        
        foreach (Product product in _shoppingCart)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductId()}) x{product.GetQuantity()}\n";
        }
        
        return label;
    }

    // Return string for shipping label
    public string GetShippingLabel()
    {
        string label = "=== SHIPPING LABEL ===\n\n";
        label += $"Ship To: {_customer.GetCustomerName()}\n";
        label += _address.GetFullAddress();
        return label;
    }

    // Get order summary with itemized costs
    public string GetOrderSummary()
    {
        string summary = "=== ORDER SUMMARY ===\n";
        summary += $"Customer: {_customer.GetCustomerName()}\n\n";
        
        double subtotal = 0;
        foreach (Product product in _shoppingCart)
        {
            double itemTotal = product.GetTotalCost();
            subtotal += itemTotal;
            summary += $"- {product.GetName()} x{product.GetQuantity()} @ ${product.GetPrice():F2} = ${itemTotal:F2}\n";
        }
        
        summary += $"\nSubtotal: ${subtotal:F2}\n";
        summary += $"Shipping: ${_address.GetShippingCost():F2}\n";
        summary += $"TOTAL: ${CalculateTotalPrice():F2}\n";
        
        return summary;
    }
}