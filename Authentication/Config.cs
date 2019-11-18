using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace Authentication
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };


        public static IEnumerable<ApiResource> Apis =>
            new List<ApiResource>
            {
                new ApiResource("customersAPI", "Customers API"),
                new ApiResource("productsAPI", "Products API")
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "customersSwagger",

                    AllowedGrantTypes = GrantTypes.Implicit,
                    RequireConsent = false,

                    // where to redirect to after login
                    RedirectUris = { 
                        "http://localhost:5002/swagger/oauth2-redirect.html",
                    },
                    AllowedCorsOrigins = new string[] { 
                        "http://localhost:5002", 
                    },
                    AllowAccessTokensViaBrowser = true,
                    AllowedScopes = new List<string>
                    {
                        "customersAPI"
                    },
                },
                 new Client
                {
                    ClientId = "productsSwagger",

                    AllowedGrantTypes = GrantTypes.Implicit,
                    RequireConsent = false,

                    // where to redirect to after login
                    RedirectUris = {
                        "http://localhost:5003/swagger/oauth2-redirect.html",
                    },
                    AllowedCorsOrigins = new string[] {
                        "http://localhost:5003",
                    },
                    AllowAccessTokensViaBrowser = true,
                    AllowedScopes = new List<string>
                    {
                        "productsAPI"
                    },
                }
            };
    }
}