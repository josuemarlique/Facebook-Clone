using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using Microsoft.AspNet.Identity;

namespace FacebookClone.Helpers
{
    public static class IdentityExtension
    {
        public static string GetFirstName(this IIdentity identity)
        {
            if (identity == null)
            {
                throw new ArgumentException("Identity");
            }

            var claimsIdentity = identity as ClaimsIdentity;

            return claimsIdentity?.FindFirstValue("FirstName");
        }
    }
}