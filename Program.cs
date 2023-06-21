using Microsoft.EntityFrameworkCore;
using GradesBooks;
using GradesBooks.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Add EF Code Dependency Injection (DI)
builder.Services.AddDbContext<StudentContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("StudentContext")));

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
