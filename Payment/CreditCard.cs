using Bangazon.Orders;

namespace Bangazon.Payments
{
  public class CreditCard: Payment 
  {

    public string bankName { get; set; }
    public string accountNumber { get; set; }
//below is a constructor. Constructors always have the same name as the class. this constructor accepts an order as an argument and it will run whatever is in the object and then  it refers us back to the base class for it's methods and properties. so if he put a console.writeline in here it would do this first and then do the base functionality. don t need to say Order order inside base because you've already stated the class so you don't need it the second time
    public CreditCard(Order order): base(order)
    {

    }
    public override string process()
    {
      return $"You are using a {this.bankName} card, with the account number {this.accountNumber}\n{base.process()}";
    }
  }
}
//when process is called and a creditcard is run the above method overrides the base method... but at the end of the return he calls the base process method so that it would run that as well. if he typed string parentFunctionality = base.process() before the return it would change the behavior

//when you create a method or variable you must spell out a type but when you're passing variables you don't have to spell out the type again. it is already a type.