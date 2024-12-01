public class Product
{
    private string _name { get; set; }
    private string _productId { get; set; }
    private decimal _price { get; set; }
    private int _quantity { get; set; }

    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetProductDetails()
    {
        return $"{_name} (ID: {_productId})";
    }
}