public class Product
{
  private string _prodName;
  private int _prodID;
  private double _prodPrice;
  private int _prodQty;

  public Product(string name, int id, double price, int quantity)
  {
    _prodName = name;
    _prodID = id;
    _prodPrice = price;
    _prodQty = quantity;
  }

  public double GetPrice()
  {
    return _prodPrice;
  }
  public double GetQty()
  {
    return _prodQty;
  }

  public void prodSummary()
  {
    Console.WriteLine($"**ID Product 00{_prodID}\n{_prodName} - (Qty: {_prodQty})\nUnit price: ${_prodPrice}");
  }

}