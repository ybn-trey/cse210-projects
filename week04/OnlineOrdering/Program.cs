using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Pear St", "Carlifonia", "LA", "USA");
        Customer customer1 = new Customer("Antonia Gentry", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Rice", "R001", 15.79m, 1));
        order1.AddProduct(new Product("Bread", "B045", 1.60m, 4));

        
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jason Tatum", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Basketball", "B078", 50.00m, 2));
        order2.AddProduct(new Product("Arm guard", "AG032", 15.00m, 2));

        
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalCost() + "\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalCost());
    }
}