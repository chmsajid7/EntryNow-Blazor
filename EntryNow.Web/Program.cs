using EntryNow.Web.Services.Implementation;
using EntryNow.Web.Services.Interface;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EntryNow.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services
                .AddScoped<IAccountService, AccountService>()
                .AddScoped<IAlertService, AlertService>()
                .AddScoped<IHttpService, HttpService>()
                .AddScoped<ILocalStorageService, LocalStorageService>();

            //builder.Services.AddHttpClient();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            //builder.Services.AddScoped(x => 
            //{
            //    var apiUrl = new Uri(builder.Configuration["apiUrl"]);
            //    return new HttpClient() { BaseAddress = apiUrl };

            //    //if (builder.Configuration["fakeBackend"] == "true")
            //    //{
            //    //    var fakeBackendHandler = new Helpers.FakeBackendHandler(x.GetService<ILocalStorageService>());
            //    //    return new HttpClient(fakeBackendHandler) { BaseAddress = apiUrl };
            //    //}

                
            //});

            var host = builder.Build();

            var accountService = host.Services.GetRequiredService<IAccountService>();
            await accountService.Initialize();

            await host.RunAsync();
        }
    }
}
