using System;
using Bangazon.Orders;

namespace Bangazon.Payments
{
  public class Payment {
    public double amount { get; set; }

    private Order _order = null; //property

    public Order order  //this is property
    {
      get {
        return _order;
      }
    }
                      //below is a constructor, it accepts an order
    public Payment(Order order) 
    {
      _order = order;
    }
                      //below is a method
    public virtual string process()  
    {
      return $"You paid ${this.amount} for order {this.order.orderNumber}"; 
    }
                      //below is a method. this method is an example of overloading because the program will choose which confirm to use based on the name and the number of arguments (called signature)
    public void confirm(string email)
    {
      Console.WriteLine($"Sending confirmation email to {email}");
    }
                      //below is a method
    public void confirm(string email, string cc)
    {
      Console.WriteLine($"Sending confirmation email to {email} and {cc}");
    }
  }
}