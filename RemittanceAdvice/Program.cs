using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RemittanceAdvice.Models;
using RemittanceAdvice.Models.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<User, Role>(opts =>
{
    opts.Password.RequiredLength = 1;
    opts.Password.RequireNonAlphanumeric = false;
    opts.Password.RequireDigit = false;
    opts.Password.RequireLowercase = false;
    opts.Password.RequireUppercase = false;
})
    .AddEntityFrameworkStores<ApplicationContext>();

builder.Services.AddControllersWithViews();

// middlewares
var app = builder.Build();

app.UseDeveloperExceptionPage();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());

app.Run();
