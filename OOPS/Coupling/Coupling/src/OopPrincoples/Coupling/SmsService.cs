using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupling.src.OopPrincoples.Coupling
{
    public class SmsService : iNotification
    {
        public void SendNotification(string message)
        {
            System.Console.WriteLine("Sms Notification is sent: " + message);
        }
    }
}