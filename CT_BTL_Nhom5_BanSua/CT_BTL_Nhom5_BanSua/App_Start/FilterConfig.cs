using System.Web;
using System.Web.Mvc;

namespace CT_BTL_Nhom5_BanSua
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
