var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddFullStackWebUIServices();
await builder.Build().RunAsync();