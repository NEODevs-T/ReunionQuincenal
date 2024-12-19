global using Microsoft.AspNetCore.Components.Authorization;
global using Blazored.LocalStorage;
using ReunionWeb.Interface;
using BlazorStrap;
using Microsoft.EntityFrameworkCore;
using ReunionWeb.Services;

using ReunionWeb;
using Radzen;
using ReunionWeb.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddHttpClient();
builder.Services.AddServerSideBlazor();

builder.Services.AddHttpClient<IAPIReunionService, APIReunionService>(client =>
{
    client.BaseAddress = new Uri("http://neo.paveca.com.ve/ReunionApi/");
});
builder.Services.AddScoped<IDbReunionService, DbReunionService>();
builder.Services.AddScoped<IAPIReunionService, APIReunionService>();
builder.Services.AddScoped<IMaestraData, MaestraData>();
builder.Services.AddScoped<IAsistenciaReuData, AsistenciaReuData>();
builder.Services.AddScoped<IAvisadorData, AvisadorData>();
builder.Services.AddScoped<ICargoReuData, CargoReuData>();
builder.Services.AddScoped<IKsfData, KsfData>();
builder.Services.AddScoped<IPizarraData, PizarraData>();
builder.Services.AddScoped<IRespoReuData, RespoReuData>();
builder.Services.AddScoped<DialogService>();//para calendario de radzen
builder.Services.AddScoped<NotificationService>(); ;//para notificaciones de radzen

builder.Services.AddControllersWithViews();
builder.Services.AddBlazorStrap();




builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();
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
