using System;

class Program
{
  static void Main(string[] args)
  {
    //List of orders to iterate through for print
    List<Order> orders = new List<Order>();
    Console.WriteLine("PRODUCT ORDERING SYSTEM");
    Console.WriteLine("**************");
    //Creating products
    Product prod1 = new Product("Smartphone", 001, 350.5, 2);
    Product prod2 = new Product("Smart TV", 002, 900, 1);
    Product prod3 = new Product("Smart watch", 003, 100, 5);
    Product prod4 = new Product("Scooter", 004, 700, 1);
    Product prod5 = new Product("Laptop", 005, 2000, 1);
    Product prod6 = new Product("Ergonomy chair", 006, 80, 10);
    //Customer 1
    Address addressCustomer1 = new Address("Dr Anaheim", "Orlando", "Florida", "USA");
    Customer customer1 = new Customer("Martin Fierro", addressCustomer1);
    //order 1 of customer 1
    Order order1 = new Order(customer1);
    order1.products.Add(prod2);
    order1.products.Add(prod4);
    orders.Add(order1); //add order to the list of orders
    //order 2 of customer 1
    Order order2c1 = new Order(customer1);
    order2c1.products.Add(prod5);
    order2c1.products.Add(prod6);
    orders.Add(order2c1); //add order to the list of orders
    //Customer 2
    Address addressCustomer2 = new Address("Juan Florez", "A Coruña", "Galicia", "Spain");
    Customer customer2 = new Customer("María García", addressCustomer2);
    //order 2 of customer 2
    Order order3 = new Order(customer2);
    order3.products.Add(prod2);
    order3.products.Add(prod3);
    order3.products.Add(prod4);
    orders.Add(order3); //add order to the list of orders

    //displaying orders
    for (int i = 0; i < orders.Count; i++)
    {
      Console.WriteLine($"Order {i + 1} Labels");
      orders[i].shippingLabel();
      Console.WriteLine("**************");
      orders[i].packingLabel();

    }

  }
}