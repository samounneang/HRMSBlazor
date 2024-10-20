using BlazorApp9;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
//builder.RootComponents.Add
//builder.HostEnvironment
//builder.Logging
//builder.Configuration
//builder.ConfigureContainer
//builder.Services
//builder.

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Logging.SetMinimumLevel(LogLevel.Warning); // Log only warnings and above
//builder.Logging.AddProvider();
builder.Services.AddRadzenComponents();


await builder.Build().RunAsync();

