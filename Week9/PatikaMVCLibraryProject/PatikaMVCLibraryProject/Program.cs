var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // Add MVC services

var app = builder.Build();
app.UseStaticFiles(); // Add static files

// Create default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
