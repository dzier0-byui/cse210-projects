public class Customer
{
    private string _name { get; set; }
    private Address _customerAddress { get; set; }

    public Customer(string name, Address address)
    {
        _name = name;
        _customerAddress = address;
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