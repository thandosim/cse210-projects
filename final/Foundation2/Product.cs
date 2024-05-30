public class Product
{
    private string _name;
    private string _id;
    private float _price;
    private int _quantity;

    public Product(string name, string id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public float GetProductTotal()
    {
        return _price * _quantity;
    }
    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _id;
    }
}