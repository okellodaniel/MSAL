using System.Threading.Tasks;
using Microsoft.Identity.Client;
public class Program
{
    private const string _clientId = "0db441c0-d94d-4a40-b1ea-6542daf50ec7";
    private const string _tenantId = "b16ec749-3645-45f9-b332-43afb8d8db16";
    private static async Task Main(string[] args)
    {
        var app = PublicClientApplicationBuilder
        .Create(_clientId)
        .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
        .WithRedirectUri("http://localhost")
        .Build();

        string[] scopes = { "user.read" };

        var result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

        Console.WriteLine("Token : \t {0}", result.AccessToken);
    }
}
