using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection_3Types
{
    public partial class UserLogic
    {
        //private GoogleOAuthService _authService;
        //private GoogleEmailService _emailService;
        //For instance below one replaces GoogleEmailService
        //private OutlookEmailService _emailService;

        public UserLogic()
        {
            _authService = new GoogleOAuthService();
            _emailService = new GoogleEmailService();
        }

        public void Register(string emailAddress, string password)
        {
            var authResult = _authService.RegisterUser(emailAddress, password);
            _emailService.SendMail(emailAddress, authResult);
        }
    }

    public class GoogleOAuthService
    {
        public string RegisterUser(string emailAddress, string password)
        {
            //Register a new user
            return string.Empty;
        }
    }
    //public class GoogleEmailService
    //{
    //    public string SendMail(string emailAddress, string message)
    //    {
    //        //Send an email using google
    //        return string.Empty;
    //    }
    //}
    //public class OutlookEmailService
    //{
    //    public string SendMail(string emailAddress, string message)
    //    {
    //        //Send an email using outlook
    //        return string.Empty;
    //    }
    //}
}
