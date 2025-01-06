using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupling.src.OopPrincoples.Coupling
{
    public class EmailSender
    {
        public void SendEmail(string message)
        {
            System.Console.WriteLine("Sending email: " + message);
        }
    }
}