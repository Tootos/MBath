global using MBath.Client.Services.CategoryServices;
global using MBath.Client.Services.ProductServices;
global using MBath.Client.Services.CartServices;
global using MBath.Client.Services.AuthenticationServices;

global using MBath.Shared.DataTransferObjects;
global using MBath.Shared.Models;
global using MBath.Shared.Models.UserModels;

global using Microsoft.AspNetCore.Components.Authorization;
global using Blazored.LocalStorage;
using MBath.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductSrvc, ProductSrvc>();
builder.Services.AddScoped<ICategorySrvc, CategorySrvc>();
builder.Services.AddScoped<ICartSrvc,CartSrvc>();
builder.Services.AddScoped<IAuthenticationSrvc, AuthenticationSrvc>();

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();


await builder.Build().RunAsync();
