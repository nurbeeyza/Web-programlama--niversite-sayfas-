using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyzanurDuzceEduTr.Controllers.Utility
{
    public class CustomHttpsOnlyFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!Utility.isLogin)
            {
                context.HttpContext.Response.Redirect(string.Format("/Home/Login"));
            }
        }
    }
}
