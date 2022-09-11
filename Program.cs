using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using IntroToBlazor;
using IntroToBlazor.Centers;
using IntroToBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) })
    .AddScoped<INebula, Nebula>()
    .AddScoped<ISatelite,Satelite>()
    .AddScoped<IObservation, Observation>()
    .AddScoped<IControl,Control>();
;

await builder.Build().RunAsync();