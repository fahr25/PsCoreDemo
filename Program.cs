using PsCoreDemo.Repository;
using PsCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.AddScoped - ** Use this the most ** 
// creates single instance per request and will be disposed at the end of the request 

// Services in line 12 and 13 are for mock repositories for testing
// builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
// builder.Services.AddScoped<ICardRepository, MockCardRepository>();

// Services in line 16 and 17 are for real database repositories
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICardRepository, CardRepository>();

builder.Services.AddControllersWithViews();

// PostgreSQL database connection, can have multiple DbContexts, reads connection string from appsettings.json
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
