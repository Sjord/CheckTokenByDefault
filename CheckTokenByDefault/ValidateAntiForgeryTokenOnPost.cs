using System.Web.Helpers;
using System.Web.Mvc;

namespace CheckTokenByDefault
{
    public class ValidateAntiForgeryTokenOnPost : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Request.HttpMethod != "GET")
            {
                AntiForgery.Validate();
            }
        }
    }
}