namespace Blazor.FullStackWebUI.Services;

public class DummyJsonService(IHttpClientFactory _factory)
{
    public const string ClientName = "DummyJson";
    public const string BaseAddress = "https://dummyjson.com";
    internal readonly HttpClient DummyJsonClient = _factory.CreateClient(ClientName);
}