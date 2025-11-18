using Microsoft.EntityFrameworkCore;

using PsCoreDemo.Data;
using PsCoreDemo.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.AddScoped - ** Use this the most ** 
// creates single instance per request and will be disposed at the end of the request 
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICardRepository, CardRepository>();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MarketShopDbContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("MarketShopDbContextConnection"))
);

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Seed the database with initial data
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<MarketShopDbContext>();
    MarketSeedDbInitializer.Seed(context);
}


app.MapDefaultControllerRoute();

app.Run();
