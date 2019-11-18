using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection_3Types
{
    public interface IEmailService
    {
        string SendMail(string emailAddress, string message);
    }
    public class GoogleEmailService : IEmailService
    {
        public string SendMail(string emailAddress, string message)
        {
            //Send an email using google
            return string.Empty;
        }
    }

    public class OutlookEmailService : IEmailService
    {
        public string SendMail(string emailAddress, string message)
        {
            //Send an email using outlook
            return string.Empty;
        }
    }
}
