var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents();

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

app.MapRazorComponents<App>();

app.Run();
