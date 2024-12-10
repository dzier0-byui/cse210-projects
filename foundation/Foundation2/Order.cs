public class Order
{
    private List<Product> _products { get; set; }
    private Customer _orderCustomer { get; set; }

    public Order(Customer customer)
    {
        _orderCustomer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal productTotal = 0;
        foreach (var product in _products)
        {
            productTotal += product.GetTotalCost();
        }

        bool livesInUSA = _orderCustomer.LivesInUSA();
        decimal shippingCost;
        if (livesInUSA)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return productTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetProductDetails()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_orderCustomer.GetCustomerInfo()}";
    }
}