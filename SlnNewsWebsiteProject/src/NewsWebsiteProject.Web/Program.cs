using Microsoft.EntityFrameworkCore;
using NewsWebsiteProject.Application.Services.SQLServerServices;
using NewsWebsiteProject.Domain.IRepositories;
using NewsWebsiteProject.Domain.IServices;
using NewsWebsiteProject.Infra.Data.Context;
using NewsWebsiteProject.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SQLServerContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));

// ** Dependency Injection
// Repositories
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<INewsRepository, NewsRepository>();

// Services
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<INewsService, NewsService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
