using System.Web;
using System.Web.Mvc;

namespace Celibate_Music_API_MAIN
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
