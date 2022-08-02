using AuxiliarSIGO.Data;
using AuxiliarSIGO.Models;
using BlazorStrap;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IConsultas, Consultas>();
builder.Services.AddDbContext<SIGOContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SIGO"));

});

builder.Services.AddBlazorStrap();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
