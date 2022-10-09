using System;

namespace CICDWebApp
{
     public class Authentication
     {
        public bool AuthenticateUser(string username, string password)
        {
            if (!(String.IsNullOrEmpty(username)) && !(String.IsNullOrEmpty(password)))
            {
                if(username == "vinay" && password == "password"){
                    return true;
                }
            }
            return false;
        }
     }
}