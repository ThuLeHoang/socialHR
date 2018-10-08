using System.Web.Mvc;

namespace socialHR.Areas.Employer
{
    public class EmployerAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Employer";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Employer_default",
                "Employer/{controller}/{action}/{id}",
                new { action = "Login",Controller="HomeController", id = UrlParameter.Optional }
            );
        }
    }
}