class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zipCode;
    private string _province;
    private string _country;
    private double _shippingCost;

    // Method to initialize address fields
    public void SetAddress(string streetAddress, string city, string state, 
                          string zipCode, string province, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _province = province;
        _country = country;
        
        // Set shipping cost based on location
        if (IsInUS())
        {
            _shippingCost = 5.00;
        }
        else
        {
            _shippingCost = 35.00;
        }
    }

    // Method to check if address is in the US
    public bool IsInUS()
    {
        return _country == "United States" || _country == "USA" || _country == "US";
    }

    // Get shipping cost
    public double GetShippingCost()
    {
        return _shippingCost;
    }

    // Method to return formatted address
    public string GetFullAddress()
    {
        if (IsInUS())
        {
            return $"{_streetAddress}\n{_city}, {_state} {_zipCode}\n{_country}";
        }
        else
        {
            return $"{_streetAddress}\n{_city}, {_state}\n{_province}\n{_country}";
        }
    }
}