using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register Syncfusion Blazor service
builder.Services.AddSyncfusionBlazor();

// Register Syncfusion Localization Service
builder.Services.AddSingleton<ISyncfusionStringLocalizer, SyncfusionStringLocalizer>();

await builder.Build().RunAsync();
