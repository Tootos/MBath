global using MBath.Client.Services.CategoryServices;
global using MBath.Client.Services.ProductServices;
global using MBath.Client.Services.CartServices;
global using MBath.Shared.DataTransferObjects;
global using MBath.Shared.Models;


global using Blazored.LocalStorage;
using MBath.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService,CartService>();


await builder.Build().RunAsync();
