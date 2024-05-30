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
        Console.WriteLine("Packing Label");
        Console.WriteLine("______________");
        Console.WriteLine("ID   | Product");
        foreach (var product in _products)
        {
            Console.WriteLine(product.GetId() + " | " + product.GetName());
        }
        Console.WriteLine();
    }

    public void ShippingLabel()
    {
        Console.WriteLine(_customer.GetName()); 
        Console.WriteLine(_customer.GetAddress());
        Console.WriteLine();
    }
}