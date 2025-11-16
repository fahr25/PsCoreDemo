using PsCoreDemo.Repository;
using PsCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.AddScoped - creates single instance per request and will be disposed at the end of the request
// builder.Services.AddTransient - creates a new instance every time it is requested
// builder.Services.AddSingleton - creates a single instance for the entire application lifetime

builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<ICardRepository, MockCardRepository>();

builder.Services.AddControllersWithViews();

// Added framework for PostgreSQL database connection, can have multiple DbContexts, reads connection string from appsettings.json
builder.Services.AddDbContext<MarketShopDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("MarketShopDbContextConnection"))
);

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}


app.MapDefaultControllerRoute();

app.Run();
