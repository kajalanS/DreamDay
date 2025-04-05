using DreamDay.Data;
using DreamDay.Extensions;
using DreamDay.Models;
using DreamDay.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.ConfigureMailTrapServices(builder.Configuration);
builder.Services.ConfigureGmailServices(builder.Configuration);
builder.Services.ConfigureDatabaseServices(builder.Configuration, ConnectionType.MySql);
builder.Services.ConfigureCustomRoleServices(builder.Configuration);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
