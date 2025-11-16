var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.AddScoped - creates single instance per request and will be disposed at the end of the request
// builder.Services.AddTransient - creates a new instance every time it is requested
// builder.Services.AddSingleton - creates a single instance for the entire application lifetime

builder.Services.AddScoped<ICatergoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IProductRepository, MockProductRepository>();

builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}


app.MapDefaultControllerRoute();

app.Run();
