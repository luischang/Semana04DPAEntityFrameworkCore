using Microsoft.EntityFrameworkCore;
using Semana05DPAMVC.DatabaseFirst.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Get ConnectionString
var cnx = builder.Configuration.GetConnectionString("DevConnection");
// Add DbContext
builder.Services
    .AddDbContext<Liga2DbContext>(options => options.UseSqlServer(cnx));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
