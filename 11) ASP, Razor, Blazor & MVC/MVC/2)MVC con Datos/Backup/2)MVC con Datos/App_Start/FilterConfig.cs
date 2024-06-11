using System.Web;
using System.Web.Mvc;

namespace _2_MVC_con_Datos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}