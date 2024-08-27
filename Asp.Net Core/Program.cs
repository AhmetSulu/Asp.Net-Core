var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



// Controller: HTTP isteklerini i�leyen s�n�f.
// Action: Controller i�inde belirli bir iste�i i�leyen metod.
// Model: Uygulaman�n veri yap�s�n� tan�mlar.
// View: Kullan�c�ya g�sterilen aray�z.
// Razor: View'lerde HTML ve C# kodlar�n� birlikte kullanma syntax'�.
// RazorView: Razor kullan�larak olu�turulan View dosyas� (.cshtml).
// wwwroot: Statik dosyalar�n bulundu�u klas�r (CSS, JS, img).

