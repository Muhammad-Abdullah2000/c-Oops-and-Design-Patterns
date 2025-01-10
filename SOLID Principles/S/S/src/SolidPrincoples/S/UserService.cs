using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S.src.SolidPrincoples.S
{
    public class UserService
    {
        public void RegisterUser(User user)
        {
            ///// Register Logic
            ///  Sending Email

            EmailSender emailSender = new EmailSender();
            emailSender.SenEmail(user.Email, "Welcome to our Platform");
        }
    }
}