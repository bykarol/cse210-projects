public class Order
{
  public List<Product> products = new List<Product>();
  private Customer _customer = new Customer();

  public Order(Customer customer)
  {
    _customer = customer;

  }

  private void displayTotal()
  {
    Console.WriteLine($"TOTAL: ${calculateTotal()}");
  }

  private double calculateTotal()
  {
    double sum = 0;
    foreach (Product prod in products)
    {
      sum += prod.GetPrice() * prod.GetQty();
    }
    if (_customer.isInUSA())
    {
      return sum + 5;

    }
    return sum + 35;
  }

  public void packingLabel()
  {
    Console.WriteLine("PACKING LABEL");
    foreach (Product prod in products)
    {
      prod.prodSummary();
    }
    Console.WriteLine("**************");
    displayTotal();
    Console.WriteLine("**************");
  }

  public void shippingLabel()
  {
    Console.WriteLine("SHIPPING LABEL");
    Console.WriteLine($"Customer: {_customer.GetCustomerName()}");
    Console.WriteLine($"Shipping Address:\n{_customer.GetCustomerAddress()}");
  }
}