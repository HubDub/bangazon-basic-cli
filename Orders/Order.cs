using System;
using System.Collections.Generic;

namespace Bangazon.Orders
{
  public class Order {
                //below is a new list that will inherit properties and methods from the collection list
    private List<string> _products = new List<string>();

    public List<string> products
    {
      get {
        return _products;
    }
  }

    private Guid _orderNumber = System.Guid.NewGuid();
    //we can remove the system. here but I left it just to show that it worked. you would HAVE to put it here if you did not have using system on the top
    
    public Guid orderNumber {
      get {
        return _orderNumber;
      }
    }
              //below is a method and a string called product is being passed into it
    public void addProduct(string product)
    {
      _products.Add(product);
    }

//the below method does not need the product passed into it because it is a method on order, so it already has the list of prodcuts. the method above needed the product passed into it because it was creating the list.
    public string listProducts()
    {
      string output = "";

      foreach (string product in _products)
      {
        output += $"\nYou ordered {product}";
      }

      return output;
    }
  }
}