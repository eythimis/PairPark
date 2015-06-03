using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Security.OAuth;
using PairPark.Model;

namespace PairPark.Utils
{
    public class AuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            //read credentials from database
            using(var db = new pairparkEntities())
            {
                drivers driver = (from d in db.drivers
                            where d.nickname == context.UserName
                            select d).FirstOrDefault();

                if(driver == null)
                {
                    context.Rejected();
                    return;
                }
            }

            
            //create Claims to store in OAuth token
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("name", context.UserName));

            context.Validated(identity);
        }

    }
}
