using Pelada.Data;
using Microsoft.EntityFrameworkCore;
using Pelada.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<JogadorRepository>();
builder.Services.AddScoped<TimeRepository>();


var configuration = builder.Configuration;
builder.Services.AddDbContext<PeladaContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("myconn")));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler("/Home/Error");

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Jogador}/{action=Index}/{id?}");
});

app.Run();
