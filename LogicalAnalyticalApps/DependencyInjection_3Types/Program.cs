using System;

namespace DependencyInjection_3Types
{
    //1. Constructor Injection
    public partial class UserLogic
    {
        private GoogleOAuthService _authService;
        private IEmailService _emailService;

        public UserLogic(IEmailService emailService)
        {
            _authService = new GoogleOAuthService();
            _emailService = emailService;
        }
    }
    //2. Setter Injection
    public partial class UserLogic
    {
        public IEmailService EmailService
        {
            get
            {
                return _emailService;
            }
            set
            {
                _emailService = value;
            }
        }
    }
    public partial class UserLogic
    {
        public void Register(string emailAddress, string password, IEmailService emailService)
        {
            var authResult = _authService.RegisterUser(emailAddress, password);
            emailService.SendMail(emailAddress, authResult);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string email=string.Empty;
            string password=string.Empty;
            //1. Constructor Injection
            //The part of the code calling the UserLogic class would have to specify what email service going to be used and 
            //pass it in the constructor when instantiating it.
            GoogleEmailService googleEmailService = new GoogleEmailService();
            UserLogic userLogic1 = new UserLogic(googleEmailService);
            //2.Setter Injection
            //The part of the code calling the UserLogic class would have to specify what email service going to be used and 
            //as one of its property.
            OutlookEmailService outlookEmailService1 = new OutlookEmailService();
            UserLogic userLogic2 = new UserLogic()
            {
                EmailService = outlookEmailService1
            };
            //3. Method Injection
            //The part of the code calling the UserLogic Register method would have to specify what email service as one of the parameters.
            OutlookEmailService outlookEmailService2 = new OutlookEmailService();
            UserLogic userLogic = new UserLogic();
            userLogic.Register(email, password, outlookEmailService2);
        }
    }
}
