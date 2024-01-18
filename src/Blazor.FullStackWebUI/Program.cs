var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    // Adds services to support rendering interactive server components in a razor components application.
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient(DummyJsonService.ClientName,
    client => client.BaseAddress = new Uri(DummyJsonService.BaseAddress));
builder.Services.AddSingleton<IDummyJsonService<Post>, PostService>();

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
    //Configures the application to support the InteractiveServer render mode.
    .AddInteractiveServerRenderMode();

app.Run();
