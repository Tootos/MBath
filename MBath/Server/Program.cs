global using MBath.Shared;
global using MBath.Shared.Models;
global using MBath.Shared.Models.UserModels;
global using MBath.Shared.DataTransferObjects;
global using Microsoft.EntityFrameworkCore;
global using MBath.Server.Data;
global using MBath.Server.Services.ProductServices;
global using MBath.Server.Services.CategoryServices;
global using MBath.Server.Services.CartServices;
global using MBath.Server.Services.AuthenticationServices;
global using MBath.Server.Services.OrderService;
global using MBath.Server.Services.PaymentService;
global using MBath.Server.Services.AddressService;
global using MBath.Server.Services.VariantService;

using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductSrvc, ProductSrvc>();
builder.Services.AddScoped<ICategorySrvc, CategorySrvc>();
builder.Services.AddScoped<ICartSrvc,CartSrvc>();
builder.Services.AddScoped<IOrderSrvc,OrderSrvc>();
builder.Services.AddScoped<IPaymentSrvc, PaymentSrvc>();
builder.Services.AddScoped<IAuthenticationSrvc, AuthenticationSrvc>();
builder.Services.AddScoped<IAddressSrvc, AddressSrvc>();
builder.Services.AddScoped<IVariantSrvc, VariantSrvc>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8
            .GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        };

    });

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseSwagger();

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
