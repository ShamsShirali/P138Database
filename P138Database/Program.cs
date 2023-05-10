using Microsoft.EntityFrameworkCore;
using P138Database.DataAccessLayer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=LAPTOP-SV67CCIP\\SQLEXPRESS;Database=P138DatabaseDb;Trusted_Connection=true");
});

var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();
