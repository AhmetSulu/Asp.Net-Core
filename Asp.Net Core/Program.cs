var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



// Controller: HTTP isteklerini iþleyen sýnýf.
// Action: Controller içinde belirli bir isteði iþleyen metod.
// Model: Uygulamanýn veri yapýsýný tanýmlar.
// View: Kullanýcýya gösterilen arayüz.
// Razor: View'lerde HTML ve C# kodlarýný birlikte kullanma syntax'ý.
// RazorView: Razor kullanýlarak oluþturulan View dosyasý (.cshtml).
// wwwroot: Statik dosyalarýn bulunduðu klasör (CSS, JS, img).

