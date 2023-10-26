var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews().AddSessionStateTempDataProvider();
var app = builder.Build();
app.UseRouting();
app.UseStaticFiles();

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
