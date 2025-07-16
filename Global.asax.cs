using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Insurance_Enrollment_2024
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_BeginRequest()
        {
            /*
            if (!Context.Request.IsSecureConnection)
                //Response.Redirect(Context.Request.Url.ToString().Replace("http:", "https:"));
                Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri.Replace("http://", "https://"));
            else if (HttpContext.Current.Request.Url.Scheme == "http")
                Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri.Replace("http://", "https://"));
            */
        }

        protected void Application_Start()
        {
            /*
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            */

            //RegisterRoutes2(RouteTable.Routes);
            //var url = RouteData.Values["mypageName"].ToString();
            //RouteTable.Routes.RouteExistingFiles = true;
            RouteTable.Routes.MapPageRoute("miamidade", "miamidade", "~/miamidade.aspx");
            //RouteTable.Routes.MapPageRoute("miamidade", "miamidade", "~/ae-forms.aspx?form=miamidade");

            //RouteTable.Routes.MapPageRoute("forms", "forms", "~/ae-forms.aspx?form=tax");
            RouteTable.Routes.MapPageRoute("forms", "forms", "~/forms.aspx");

        }



    }
}
