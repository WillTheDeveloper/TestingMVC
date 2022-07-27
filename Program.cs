using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Post.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TestingMVCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TestingMVCContext") ?? throw new InvalidOperationException("Connection string 'TestingMVCContext' not found.")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

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
