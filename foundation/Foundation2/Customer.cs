public class Customer
{
    private string _name;
    private Address _customerAddress;

    public Customer(string name, Address address)
    {
        _name = name;
        _customerAddress = address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetCustomerAddress()
    {
        return _customerAddress;
    }

    public bool LivesInUSA()
    {
        return _customerAddress.IsInUSA();
    }

    public string GetCustomerInfo()
    {
        return $"{_name}\n{_customerAddress.GetFullAddress()}";
    }
}