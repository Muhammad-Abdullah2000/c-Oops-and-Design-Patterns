using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupling.src.OopPrincoples.Coupling
{
    public class Order
    {
        public void PlaceOrder()
        {
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail("Order Placed Successfully");
        }
    }
}