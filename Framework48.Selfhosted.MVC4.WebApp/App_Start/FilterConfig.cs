using System.Web;
using System.Web.Mvc;

namespace Framework48.Selfhosted.MVC4.WebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
