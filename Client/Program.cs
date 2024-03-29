global using CaseFichasMedicas.Client.Services.RoleService;
global using CaseFichasMedicas.Shared;
using CaseFichasMedicas.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("CaseFichasMedicas.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("CaseFichasMedicas.ServerAPI"));
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddApiAuthorization();

await builder.Build().RunAsync();
