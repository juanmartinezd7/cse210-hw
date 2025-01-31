using System;

class Program
{
    static void Main(string[] args)
    {
        //Address
        Address address1 = new Address("1735 Sandy Lake Rd", "Carrollton", "TX", "USA");
        Address address2 = new Address("300 E. Pioneer st", "Irving", "TX", "USA");


        //Customers
        Customer customer1 = new Customer("Paul McGee", address1);
        Customer customer2 = new Customer("John Burket", address2);


        //Products
        Product product1 = new Product("Flat Bar 4'", 404, 200.00, 5);
        Product product2 = new Product("Level 10'", 110, 400.00, 3);
        Product product3 = new Product("Arch 12'", 612, 250.00, 2);
        Product product4 = new Product("Billet 4'", 304, 350.00, 3);


        //Orders
        Order order1 = new Order(customer2);
        order1.AddProduct(product1);
        order1.AddProduct(product4);


        Order order2 = new Order(customer1);
        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);


        //Order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();


        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
        Console.WriteLine();

    }
}