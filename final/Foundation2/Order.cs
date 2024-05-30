public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public float GetTotal()
    {
        float shipping;
        if (_customer.IsUsa() == true)
        {
            shipping = 5;
        }
        else 
        {
            shipping = 35;
        }

        float runTotal = 0;
        foreach(var product in _products)
        {
            runTotal += product.GetProductTotal();
        }

        return runTotal + shipping;
    }

    public void PackingLabel()
    {
        foreach (var product in _products)
        {
            Console.WriteLine(product.GetName() + " " + product.GetId());
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine(_customer.GetName() + " " + _customer.GetAddress());
    }
}