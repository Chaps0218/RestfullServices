using System.Web;
using System.Web.Mvc;

namespace CONVUNI_RESTFULL_DOTNET_CLIESC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
