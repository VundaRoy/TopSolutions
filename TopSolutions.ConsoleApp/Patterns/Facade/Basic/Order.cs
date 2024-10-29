using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Facade.Basic
{
    public class Order
    {
        // The Facade class provides a simple interface to the complex logic of one
        // or several subsystems. The Facade delegates the client requests to the
        // appropriate objects within the subsystem. 
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            //Get the Product Details
            Product product = new();
            product.GetProductDetails();
            //Make the Payment
            Payment payment = new();
            payment.MakePayment();
            //Send the Invoice
            Invoice invoice = new();
            invoice.Sendinvoice();
            Console.WriteLine("Order Placed Successfully");
        }
    }
}
