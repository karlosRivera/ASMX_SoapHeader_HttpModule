using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace CustomAuthWithHTTPModule
{
    /// <summary>
    /// Summary description for SecureWebService
    /// </summary>
    public class Authentication : SoapHeader
    {
        public string User;
        public string Password;
    }

    public class SecureWebService : WebService
    {
        public Authentication authentication;

        [WebMethod]
        [SoapHeader("authentication", Required = true)]
        public string ValidUser()
        {
            string xx = authentication.User + " " + authentication.Password;

            if (User.IsInRole("Customer"))
                return "User is in role customer";

            if (User.Identity.IsAuthenticated)
                return "User is a valid user";
            return "not authenticated";
        }

    }

}