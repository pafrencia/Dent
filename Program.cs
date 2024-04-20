

using Dent.Data;
using Dent.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);
#if DEBUG
builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    // Carga la configuración desde appsettings.json
    config.AddJsonFile("appsettings.Debug.json", optional: false, reloadOnChange: true);
});
#else
builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    // Carga la configuración desde appsettings.json
    config.AddJsonFile("appsettings.Release.json", optional: false, reloadOnChange: true);
});
#endif
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<AgregarPracticas>();
builder.Services.AddSingleton<EliminarPracticaMetod>();
builder.Services.AddSingleton<DbDentistaContext>();
builder.Services.AddSingleton<ServicioAutenticacion>();
builder.Services.AddSingleton<Permisos>();
builder.Services.AddSingleton<ServiceHelper>();
builder.Services.AddHttpClient();
var app = builder.Build();
// Obtén el servicio Provider
var serviceProvider = app.Services;

// Llama a SetConfig y pásale el servicio Provider
ServiceHelper.SetConfig(serviceProvider);
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
