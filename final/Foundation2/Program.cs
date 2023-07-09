using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Create orders
        List<Order> orders = CreateOrders();

        // Display order information
        foreach (Order order in orders)
        {
           // Console.WriteLine("Order #:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("Total Price: $" + order.GetTotalPrice());
            Console.WriteLine();
        }

        Console.ReadLine();
    }

    static List<Order> CreateOrders()
    {
        List<Order> orders = new List<Order>();

        Console.Write("Enter the number of orders to create: ");
        int numberOfOrders = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfOrders; i++)
        {
            Order order = CreateOrder(i + 1);
            orders.Add(order);
        }
        
        return orders;
        
    }

    static Order CreateOrder(int orderNumber)
    {
        Console.Clear();
        Console.WriteLine($"Order #:{orderNumber}");
        // Create customer
        Customer customer = CreateCustomer();

        // Create products
        List<Product> products = CreateProducts();

        // Create order
        Order order = new Order(orderNumber, customer);

        foreach (Product product in products)
        {
            order.AddProduct(product);
        }

        return order;
    }

    static Customer CreateCustomer()
    {
        Console.WriteLine("Customer Name:");

        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Address address = CreateAddress();

        return new Customer(name, address);
    }

    static Address CreateAddress()
    {
        Console.WriteLine("Address:");

        Console.Write("Enter street: ");
        string street = Console.ReadLine();

        Console.Write("Enter city: ");
        string city = Console.ReadLine();

        Console.Write("Enter state/province/ZIP: ");
        string state = Console.ReadLine();

        Console.Write("Enter country: ");
        string country = Console.ReadLine();

        return new Address(street, city, state, country);
    }

    static List<Product> CreateProducts()
    {
        List<Product> products = new List<Product>();

        Console.Write("Enter the number of products: ");
        int numberOfProducts = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfProducts; i++)
        {
            Console.WriteLine($"Product {i + 1}:");
            Product product = CreateProduct();
            products.Add(product);
        }
        Console.Clear();
 
        return products;

    }

    static Product CreateProduct()
    {
        Console.WriteLine("================================================================");
        Console.Write("Enter description: ");
        string name = Console.ReadLine();

        Console.Write("Enter product id: ");
        string productId = Console.ReadLine();

        Console.Write("Enter price : $ ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter quantity: ");
        int quantity = int.Parse(Console.ReadLine());  

        Console.WriteLine("================================================================");

        return new Product(name, productId, price, quantity);
    }

}