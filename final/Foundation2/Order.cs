class Order
{
    private int orderNumber;
    private List<Product> products;
    private Customer customer;

    public int OrderNumber
    {
        get { return orderNumber; }
        private set { orderNumber = value; }
    }

    public Customer Customer
    {
        get { return customer; }
        private set { customer = value; }
    }

    public Order(int orderNumber, Customer customer)
    {
        OrderNumber = orderNumber;
        Customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.GetPrice();
        }

        if (Customer.IsInUSA())
        {
            totalPrice += 5; // USA shipping cost
        }
        else
        {
            totalPrice += 35; // Non-USA shipping cost
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
       
        string packingLabel = $"Order Number: {OrderNumber}\n";
        Console.WriteLine("...................................................................");
        packingLabel += "Packing Label:\n";                                                   
        foreach (Product product in products)
        {
            packingLabel += $"Product: {product.Name.Capitalize()} (ID: {product.ProductId})\n";
        }
        Console.WriteLine("...................................................................");

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Order Number: {OrderNumber}\n";
        Console.WriteLine("-------------------------------------------------------------------");
        shippingLabel += "Shipping Label:\n";
        shippingLabel += $"Customer: {Customer.Name.Capitalize()}\n";
        shippingLabel += "Address:\n" + Customer.Address.GetAddressString();
        Console.WriteLine("-------------------------------------------------------------------");

        return shippingLabel;
    }  

}