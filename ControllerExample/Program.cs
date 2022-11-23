var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    "counter",
    "awesome-counter/{id=0}",
    new { controller = "Counter", action = "Index" }
);

// app.MapDefaultControllerRoute();
app.MapControllerRoute(
    "default",
    "{controller=Home}/{action=Index}/{id?}"
);

app.Run();