var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


var app = builder.Build();
var message = app.Configuration.GetSection("Message")["meet"];

//app.MapGet("/", () => message);
/*
 *  Soda dolum tesisi
 *  1. Şişeye etiket bas -> Middleware
 *  2. Sodayı şişeye doldur
 *  3. Kapağı kapat
 *  4. Kasaya yerleştir.
 */
//app.UseWelcomePage();
app.UseStaticFiles();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");


app.Run();
