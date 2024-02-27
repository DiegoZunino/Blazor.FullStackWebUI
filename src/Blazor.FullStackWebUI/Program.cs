var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    // Adds services to support rendering interactive server components in a razor components application.
    //.AddInteractiveServerComponents()
    // Adds services to support rendering interactive WebAssembly components.
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddFullStackWebUIServices();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    // Configures the application to support the InteractiveServer render mode.
    //.AddInteractiveServerRenderMode()
    // Configures the application to support the InteractiveWebAssembly render mode
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Counter).Assembly);

app.Run();
