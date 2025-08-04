using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        // Create first customer and address (US)
        Customer customer1 = new Customer();
        customer1.SetCustomerName("Joseph Smith");
        
        Address address1 = new Address();
        address1.SetAddress(
            "123 Main St",
            "Anytown",
            "CA",
            "90210",
            "",
            "USA");

        // Create first order
        Order order1 = new Order(customer1, address1);

        // Add products to first order with specific quantities
        List<Product> shoppingCart1 = new List<Product>
        {
            CreateProductWithQuantity(1406, 3), // 3 Precept Chips
            CreateProductWithQuantity(1407, 2), // 2 L.U.L Popcorn
            CreateProductWithQuantity(1405, 1), // 1 Liahona Burger Patties
            CreateProductWithQuantity(3579, 4), // 4 Celsius Energy Drink
            CreateProductWithQuantity(3580, 2)  // 2 Monster Energy Drink
        };

        // Add products to order
        order1.AddProducts(shoppingCart1);

        // Display first order
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetOrderSummary());
        Console.WriteLine("\n" + new string('=', 60) + "\n");

        // Create second customer and address (International)
        Customer customer2 = new Customer();
        customer2.SetCustomerName("Kevin Bacon");
        
        Address address2 = new Address();
        address2.SetAddress(
            "456 Elm St",
            "Othertown",
            "ON",
            "K1A 0B1",
            "Ontario",
            "Canada");

        // Create second order
        Order order2 = new Order(customer2, address2);

        // Add different products to second order
        List<Product> shoppingCart2 = new List<Product>
        {
            CreateProductWithQuantity(1406, 1), // 1 Precept Chips
            CreateProductWithQuantity(3579, 2), // 2 Celsius Energy Drink
            CreateProductWithQuantity(1405, 2)  // 2 Liahona Burger Patties
        };

        order2.AddProducts(shoppingCart2);

        // Display second order
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetOrderSummary());

        Console.WriteLine("\n=== END OF ORDERS ===");
    }

    // Helper method to create products with specific quantities
    private static Product CreateProductWithQuantity(int productId, int quantity)
    {
        Product baseProduct = Product.products.Find(p => p._ID == productId);
        if (baseProduct != null)
        {
            return new Product(baseProduct._ID, baseProduct._name, baseProduct._price, quantity);
        }
        return null;
    }
}