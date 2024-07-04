using System.Web;
using System.Web.Mvc;

namespace DthK22CNT4Lesson11_221900028
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
