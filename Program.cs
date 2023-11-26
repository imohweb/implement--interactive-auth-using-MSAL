using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace msal_auth {
    class Program {
        private const string _clientId = "5f64c461-ee04-44e8-a7b8-227efbb1b68a";
        private const string _tenantId = "21782ab8-787e-457e-bb51-01c5d2df065c";

       public static async Task Main(string[] args) 
       {
        var app = PublicClientApplicationBuilder
            .Create(_clientId)
            .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
            .WithRedirectUri("http://localhost" )
            .Build();
        string[] scopes = { "user.read" };
        AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

        Console.WriteLine($"Token:\t{result.AccessToken}");

       }
    }
}



