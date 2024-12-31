using Microsoft.EntityFrameworkCore;
using WebApplication13.Data;

var builder = WebApplication.CreateBuilder(args);

// Register the database context using an in-memory database
builder.Services.AddDbContext<StudentContext>(options =>
    options.UseInMemoryDatabase("StudentDB"));

// Add services for controllers with views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
