using System;

namespace Bangazon.Customers
{
  public class Customer
  {
        //below are properties of class Customer. they are strings
    public string firstName { get; set; }
    public string lastName { get; set; }
//below is a method on the class Customer        
    public void greet() 
    {
      Console.WriteLine($"Welcome {this.firstName} {this.lastName}!");
    }
  }
}