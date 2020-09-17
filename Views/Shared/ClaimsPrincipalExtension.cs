using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UserName.Extensions
{
    public static class ClaimsPrincipalExtension
    {
        public static string GetFirstName(this ClaimsPrincipal principal)
        {
            var FirstName = principal.Claims.FirstOrDefault(c => c.Type == "FirstName");
            return FirstName?.Value;
        }

        public static string GetLastName(this ClaimsPrincipal principal)
        {
            var LastName = principal.Claims.FirstOrDefault(c => c.Type == "LastName");
            return LastName?.Value;
        }
    }
}