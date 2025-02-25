using BusinessLayer.Services.Abstractions;
using BusinessLayer.Services.Concretes;
using DataAccessLayer.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ProniaDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MsSql"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddScoped<ISliderItemsService, SliderItemsService>();

var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
    );

app.MapControllerRoute
    (
    name: "default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
    );

app.Run();