using System;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;

namespace ad_service
{
    class Program
    {
        static void Main(string[] args)
        {
             using (var context = new PrincipalContext(ContextType.Domain, "domain.net", "serviceaccount user", "service account pwd"))
                {
                   
                        String userName = "username";
                        String password = "password";
                   

                    if (context.ValidateCredentials(userName, password))
                    {
                         Console.WriteLine("User exists in AD " + userName);
                         Console.WriteLine("Updating user in Okta: " + userName);
                    }
                       else
                    {
                         Console.WriteLine("Cannot authenticate user in AD: " + userName);
                    }

        }
    }
}
}
