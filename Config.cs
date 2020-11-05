using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using IdentityServer4;

namespace IdentityServer
{
    public class Config
    {
        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "commanderClient",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes =
                    {
                        "commanderAPI"
                    }
                }

            };
        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("commanderAPI", "Commander API"), 
            };
        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[]
            {
            };
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
            };
        public static List<TestUser> TestUsers =>
            new List<TestUser>
            {
            };
    }
}
