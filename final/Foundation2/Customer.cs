class Customer
{
     private string name;
    private Address address;

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public Address Address
    {
        get { return address; }
        private set { address = value; }
    }

    public Customer(string name, Address address)
    {
        Name = name.Capitalize();
        Address = address;
    }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }
}