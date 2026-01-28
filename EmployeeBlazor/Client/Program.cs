using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBlazor.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDIxMDMyN0AzMTM5MmUzMTJlMzBLQ2xOdis1eWRWSzkxZE9PSEpWay9qOUJkVlhQQkdMdzVZZ3NYYXJKVnVNPQ==;NDIxMDMyOEAzMTM5MmUzMTJlMzBWdHFiU3lLMXZWNWl4NENXclZZdEdNRHRQSEFKTjFPRjZMZTRULzZSSUpRPQ==;NDIxMDMyOUAzMTM5MmUzMTJlMzBGWjM4WUZxZDBISmJzVlE2R2tXT0w1RTN6citoMzJxVUpQYzRzQ2RLTVNRPQ==;NDIxMDMzMEAzMTM5MmUzMTJlMzBKeTlxZW5jUTdWYXRQQjVOUXhrUjFXdFJ6TmxxY1JYWXg1YTVleUphRjBBPQ==;NDIxMDMzMUAzMTM5MmUzMTJlMzBSb3g1VGZzK1JiSWtzREJ0bElEMXJWK29lc3E2TFZsaWZoM1B3TFMwZmNFPQ==;NDIxMDMzMkAzMTM5MmUzMTJlMzBYQzBscU80Q0FCaGo1MEFZdzlLUlRCQnFMRS9NUndXQXZraUJBcloyMjdrPQ==;NDIxMDMzM0AzMTM5MmUzMTJlMzBhbXhvOVMyRW4zbWY3T0JJZFJUcWJieHltbi9VWTkwUWVOL0ZCanozMUZBPQ==;NDIxMDMzNEAzMTM5MmUzMTJlMzBMd3N0NUJYWTZRVE9Na1NreFBwUHBMQm5wSEpFYkh1Yzc2U1ZpWE9WVjg0PQ==;NDIxMDMzNUAzMTM5MmUzMTJlMzBvNmQwSDdjWC9hUXNYdkg0MG4yYndFY2RnNnpmb21EZmhSMXp3WWlEelNRPQ==;NDIxMDMzNkAzMTM5MmUzMTJlMzBTOWRBa1FkdXo2OFZnNHRKTjZ6NUxqNGFrZkZ3L0JqY2k0c0Q5SW92cFlrPQ==");

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();
        }
    }
}
