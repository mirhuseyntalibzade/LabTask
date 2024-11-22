using Microsoft.EntityFrameworkCore;
using Pronia_Project.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ProniaDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSql")));

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
