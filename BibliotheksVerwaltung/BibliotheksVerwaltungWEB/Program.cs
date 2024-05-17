using BibliotheksVerwaltungLib.Interfaces;
using BibliotheksVerwaltungWEB;
using BibliotheksVerwaltungWEB.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["ApiUrl"]?.ToString() ?? string.Empty) });
builder.Services.AddScoped<IAutorService, AutorService>();
await builder.Build().RunAsync();
