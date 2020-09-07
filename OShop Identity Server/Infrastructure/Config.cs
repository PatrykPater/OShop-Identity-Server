using IdentityServer4.Models;
using System.Collections.Generic;

namespace OShop_Identity_Server.Infrastructure
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile(),
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("resourceapi", "Resource API")
                {
                    Scopes = { "api.read" }
                }
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new[]
            {
                new Client {
                    RequireConsent = false,
                    ClientId = "angular_spa",
                    ClientName = "Angular SPA",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowedScopes = 
                    { 
                        "openid"
                        //"profile", 
                        //"email", 
                        //"api.read" 
                    },
                    RedirectUris = 
                    {
                        "https://localhost:4200/auth-callback",
                        "http://localhost:4200/auth-callback",
                    },
                    PostLogoutRedirectUris = 
                    {
                        "https://localhost:4200/",
                        "http://localhost:4200/",
                    },
                    AllowedCorsOrigins = 
                    {
                        "https://localhost:4200",
                        "http://localhost:4200"
                    },
                    AllowAccessTokensViaBrowser = true,
                    AccessTokenLifetime = 3600
                }
            };
        }
    }
}
