using System.Web;
using System.Web.Mvc;

namespace _1_Intro_MVC_CSharp_Razor
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}