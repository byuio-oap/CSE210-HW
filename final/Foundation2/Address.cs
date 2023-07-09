class Address
{
    private string street;
    private string city;
    private string state;
    private string country;



    public string Street
    {
        get { return street; }
        private set { street = value; }
    }

    public string City
    {
        get { return city; }
        private set { city = value; }
    }

    public string State
    {
        get { return state; }
        private set { state = value; }
    }

    public string Country
    {
        get { return country; }
        private set { country = value; }
    }

    public Address(string street, string city, string state, string country)
    {
        
        Street = street;
        City = city;
        State = state;
        Country = country.ToLower();
    }

    public bool IsInUSA()
    {
        return Country == "usa";
    }

    public string GetAddressString()
    {
        string addressString = $"{Street}\n{City.Capitalize()}, {State.Capitalize()}\n{Country.ToUpper()}";
        return addressString;
    }






}