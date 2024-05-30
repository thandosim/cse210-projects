using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Address address1 = new Address("3 Auburn Ave", "Cleveland", "Ohio", "USA");
        Address address2 = new Address("7 Hepburn St", "Freemans Bay", "Auckland", "NZ");
        Customer customer1 = new Customer("Thando Sim", address1);
        Customer customer2 = new Customer("Mimi Mann", address2); 
        Product product1 = new Product("fish", "f001", 5, 2);
        Product product2 = new Product("bread", "b001", 3, 5);
        Product product3 = new Product("fish", "f001", 5, 3);
        Product product4 = new Product("milk", "m001", 7, 1);
        Product product5 = new Product("eggs", "e001", 1, 12);

        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product2);

        List<Product> products2 = new List<Product>();
        products2.Add(product3);
        products2.Add(product4);
        products2.Add(product5);

        Order order1 = new Order(customer1,products1);
        Order order2 = new Order(customer2,products2);

        Console.WriteLine($"Order1 Total Cost: {order1.GetTotal()}");
        order1.PackingLabel();
        order1.ShippingLabel();

        Console.WriteLine($"Order2 Total Cost: {order2.GetTotal()}");
        order2.PackingLabel();
        order2.ShippingLabel();
    }
}