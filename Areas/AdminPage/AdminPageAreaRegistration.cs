using System.Web.Mvc;

namespace doan.Areas.AdminPage
{
    public class AdminPageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AdminPage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AdminPage_LogOUT",
                "AdminPage/Logout",
                new { action = "LogOUT",Controller = "Logout", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "AdminPage_default",
                "AdminPage/{controller}/{action}/{id}",
                new { action = "Index",Controller = "Dashboard", id = UrlParameter.Optional }
            );
        }
    }
}