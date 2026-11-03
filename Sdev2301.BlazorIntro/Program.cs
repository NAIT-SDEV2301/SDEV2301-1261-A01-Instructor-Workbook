using Sdev2301.BlazorIntro.Components;
using Sdev2301.BlazorIntro.Services; // for ProductService class
using Microsoft.EntityFrameworkCore;// for UseSqlServer extension method
using Sdev2301.BlazorIntro.Data; // for AppDbContext class


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
// Register the service
builder.Services.AddScoped<ProductDisplayService>();
builder.Services.AddSingleton<SingletonMarker>();
builder.Services.AddScoped<ScopedMarker>();
builder.Services.AddTransient<TransientMarker>();

var connectionString =
    builder.Configuration.GetConnectionString("AppDbConnection")
    ?? throw new InvalidOperationException(
        "Connection string 'AppDbConnection' not found.");

builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseSqlServer(connectionString));
// Register ProductService for DI
builder.Services.AddScoped<ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
