using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S.src.SolidPrincoples.S
{
    public class EmailSender
    {
        public void SenEmail(string email, string message)
        {
            System.Console.WriteLine($"Sending Email to {email}: {message}");
        }
    }
}