class Product{

private string name;
    private string productId;
    private double price;
    private int quantity;

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public string ProductId
    {
        get { return productId; }
        private set { productId = value; }
    }

    public double Price
    {
        get { return price; }
        private set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        private set { quantity = value; }
    }

    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public double GetPrice()
    {
        return Price * Quantity;
    }
}