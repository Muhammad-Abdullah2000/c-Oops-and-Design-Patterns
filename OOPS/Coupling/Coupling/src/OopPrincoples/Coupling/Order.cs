using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupling.src.OopPrincoples.Coupling
{
    public class Order
    {

        private readonly iNotification notificationService;

        public Order(iNotification notificationService)
        {
            this.notificationService = notificationService;
        }

        public void PlaceOrder()
        {
            notificationService.SendNotification("Order Placed Successfully");
        }
    }
}