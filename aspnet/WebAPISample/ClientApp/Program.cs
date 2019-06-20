using ClientApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Http;
using Polly;
using Microsoft.Extensions.Logging;

namespace ClientApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("client - wait for the service");
            Console.ReadLine();
            //using (var client = new HttpClient())
            //{
            //    HttpResponseMessage resp = await client.GetAsync("https://localhost:44373/api/Books");
            //    resp.EnsureSuccessStatusCode();
            //    string json = await resp.Content.ReadAsStringAsync();
            //    var books = JsonConvert.DeserializeObject<IEnumerable<Book>>(json);

            //}

            await Host.CreateDefaultBuilder()
                .ConfigureLogging(config =>
                {
                    config.AddFilter(level => true);
                    config.AddConsole();
                })
                .ConfigureServices(services =>
            {
                services.AddHostedService<TheRunner>();
                services.AddHttpClient("myservice", client =>
                {
                    client.BaseAddress = new Uri("https://localhost1:44373");

                })
                .AddTransientHttpErrorPolicy(policy => policy.WaitAndRetryAsync(new[] { TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(2), TimeSpan.FromSeconds(3) }))  // network failures, HTTP 5xx, HTTP 408
                .AddTypedClient<IBooksClientService, BooksClientService>();
                // services.AddTransient<IBooksClientService, BooksClientService//>();
            }).RunConsoleAsync();

        }
    }
}
