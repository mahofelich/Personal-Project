using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PersonalProject.Client.Client;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<StandData>();
builder.Services.AddBlazorBootstrap();


await builder.Build().RunAsync();
