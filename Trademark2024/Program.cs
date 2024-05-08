using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Blazor;
using Trademark2024.Data;

var builder = WebApplication.CreateBuilder(args);

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzI1MjQ3MEAzMjM1MmUzMDJlMzBoVStMRjNldlhLd2NJaCtPc0tWVko5eklxL0g2WHhvb0R5R2tQOXZ3WEVNPQ==");

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<ITrademarkInformationRepository, TrademarkInformationRepository>();
builder.Services.AddScoped<IApplicantInformationRepository, ApplicantInformationRepository>();
builder.Services.AddScoped<IResidentAgentInformationRepository, ResidentAgentInformationRepository>();
builder.Services.AddScoped<IClaimConventionPropertyRepository, ClaimConventionPropertyRepository>();

builder.Services.AddScoped<ICountriesRepository, CountriesRepository>();
builder.Services.AddScoped<IStatesRepository, StatesRepository>();
builder.Services.AddScoped<ICitiesRepository, CitiesRepository>();
builder.Services.AddScoped<INationalitiesRepository, NationalitiesRepository>();

builder.Services.AddScoped<IGoodsClassRepository, GoodsClassRepository>();
builder.Services.AddScoped<IServicesClassRepository, ServicesClassRepository>();

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnectionString")));

var app = builder.Build();

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
