using System;
using System;

public class Address
{
    private string street;
    private string city;
    private string state;
    private string postalCode;

    public Address(string street, string city, string state, string postalCode)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.postalCode = postalCode;
    }

    public string GetFormattedAddress()
    {
        return $"{street}, {city}, {state}, {postalCode}";
    }
}