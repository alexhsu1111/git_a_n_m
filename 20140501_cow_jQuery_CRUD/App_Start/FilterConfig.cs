using System.Web;
using System.Web.Mvc;

namespace _20140501_cow_jQuery_CRUD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}