var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // MVC Services

var app = builder.Build();

app.UseStaticFiles(); // Using static files


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Routing Configuration

app.Run();

/*  
 *  Controllers: Kullanici isteklerini isleyen siniflardir
 *  Models: Uygulamanin veri yapisini temsil eder
 *  Views: Kullaniciya sunulan gorsel iceriklerdir
 *  wwwroot: Static dosyalar burada yer alir
 *  Razor: ASP.NET Core'da dinamik web sayfalari olusturmak icin kullanilan bir sablon motorudur
 *  RazorView: Razor motorunu kullanarak HTML ve C# kodlarini birlikte yazabileceginiz dosyalardir
 *  builder.Build(): Uygulamanin yapilandirmasini tamamlar
 *  app.Run(): Uygulamayi baslatir ve istekleri dinlemeye baslar
*/
