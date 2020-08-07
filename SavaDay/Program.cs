/*
    Copyright (C) 2020  Krasen Ivanov
 */

using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SavaDay
{
    public static class Program // maybe not static
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<Services.AppData>();
            builder.Services.AddBlazoredLocalStorage();

            await builder.Build().RunAsync().ConfigureAwait(false);
        }
    }
}