using System.Web;
using System.Web.Mvc;

namespace Hands_On_ActionResults_44
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
