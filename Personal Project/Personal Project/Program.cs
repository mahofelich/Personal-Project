using Personal_Project.Client.Pages;
using Personal_Project.Components;
using PersonalProject.Client.Client;
using Syncfusion.Blazor;



var builder = WebApplication.CreateBuilder(args);
var standApiUrl = builder.Configuration["StandApiUrl"]?? throw new Exception("StandApiUrl is not set");
// Add services to the container.
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NCaF5cXmtCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWXlccHVVRGJfVkF2XEA=");
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddBlazorBootstrap();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddHttpClient<StandData>(client => client.BaseAddress = new Uri(standApiUrl));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Personal_Project.Client._Imports).Assembly);

app.Run();
