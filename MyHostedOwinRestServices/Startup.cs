using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Owin;

namespace MyHostedOwinRestServices
{
    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Web API configuration and services           

            HttpConfiguration config = new HttpConfiguration();

            //Enable the CORS support
            config.EnableCors();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            app.UseWebApi(config);
        }
    }
}
