using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MauiAppBlazor.Shared.Services;
using MauiAppBlazor.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the MauiAppBlazor.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
