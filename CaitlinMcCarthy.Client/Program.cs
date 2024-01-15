using CaitlinMcCarthy.Client.Models;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register services here
builder.Services.AddSingleton<DateIdeaGenerator>();
builder.Services.AddSingleton<MessageGenerator>();

await builder.Build().RunAsync();
