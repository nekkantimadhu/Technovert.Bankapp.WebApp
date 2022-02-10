using System.Web;
using System.Web.Mvc;

namespace Technovert.BankApp.Webpages
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
