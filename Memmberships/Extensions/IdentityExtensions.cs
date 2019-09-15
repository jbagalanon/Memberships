using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Memmberships.Extensions
{
    public static class IdentityExtensions
    {
        public static   string  GetUserFirstName (this IIdentity Identity)
        {
            var db = ApplicationDbContext.Create();

        }
    }
}