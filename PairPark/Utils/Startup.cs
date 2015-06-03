using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Web.Http;
using Microsoft.Owin;
using Owin;
using Newtonsoft.Json.Serialization;
using Microsoft.Owin.Security.OAuth;
using System.Web.Http.Tracing;

[assembly: OwinStartup(typeof(PairPark.Utils.Startup))]

namespace PairPark.Utils
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //configure oauth for owin
            ConfigureOAuth(app);

            //configure owin to play with web api
            ConfigureWebApi(app);
        }

        private void ConfigureWebApi(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();

            //default route
            //configuration.Routes.MapHttpRoute(
            //    "default",
            //    "api/{controller}"
            //    );

            //to be able to set Routes on top of action, controller, etc...
            configuration.MapHttpAttributeRoutes();

            //format json output
            var jsonFormatter = configuration.Formatters.JsonFormatter;
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            
            //use cors *
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            //enable tracing
            SystemDiagnosticsTraceWriter traceWriter = configuration.EnableSystemDiagnosticsTracing();
            traceWriter.IsVerbose = true;
            traceWriter.MinimumLevel = TraceLevel.Off;

            app.UseWebApi(configuration);
        }

        private void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new AuthorizationServerProvider()              
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }
    }
}
