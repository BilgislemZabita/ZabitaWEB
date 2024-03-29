using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using Radzen;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ZabitaWEB.Client.Services.Abstract;
using ZabitaWEB.Client.Services.Concrete;

namespace ZabitaWEB.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddTransient<IAmirliksService, AmirliksService>();
            builder.Services.AddScoped<IYerleskesService, YerleskesService>();
            builder.Services.AddTransient<ITalepsService, TalepsService>();
            builder.Services.AddTransient<IFotoesService, FotoesService>();
            builder.Services.AddTransient<IPersonelsService, PersonelsService>();
            builder.Services.AddScoped<IIsTiplerisService, IsTiplerisService>();
            builder.Services.AddScoped<IIsAltTiplerisService, IsAltTipleriService>();
            builder.Services.AddScoped<ITalepAltSonucusService, TalepAltSonucusService>();
            builder.Services.AddScoped<IYerleskeTeknikBilgilersService, YerleskeTeknikBilgilersService>();
            builder.Services.AddScoped<IYerleskeBakimOnarimsService, YerleskeBakimOnarimsService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<DialogService>();
            builder.Services.AddScoped<NotificationService>();
            builder.Services.AddScoped<TooltipService>();
            builder.Services.AddScoped<ContextMenuService>();
            builder.Services.AddMudServices();
            builder.Services.AddHttpClient("ZabitaWEB.ServerAPI",
        client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>()
    .CreateClient("ZabitaWEB.ServerAPI"));
            builder.Services.AddApiAuthorization();

            await builder.Build().RunAsync();

        }
    }
}