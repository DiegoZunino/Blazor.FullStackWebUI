namespace Blazor.FullStackWebUI.Shared;

public static class Extensions
{
    public static void AddFullStackWebUIServices(this IServiceCollection services)
    {
        services.AddHttpClient(DummyJsonService.ClientName,
            client => client.BaseAddress = new Uri(DummyJsonService.BaseAddress));

        services.AddSingleton<IDummyJsonService<Post>, PostService>();

    }
}