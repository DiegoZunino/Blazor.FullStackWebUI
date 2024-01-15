namespace Blazor.FullStackWebUI.Services;

public class PostService(IHttpClientFactory factory) : DummyJsonService(factory), IDummyJsonService<Post>
{
    public async Task<List<Post>> GetList(int limit = 0, int skip = 0, int delay = 0)
    {
        var response = await DummyJsonClient.GetFromJsonAsync<PostListDto>($"posts?limit={limit}&skip={skip}&delay={delay}");
        return response.Posts;
    }
    
    public async Task<List<Post>> Search(string query, int limit = 0, int skip = 0, int delay = 0)
    {
        var response = await DummyJsonClient.GetFromJsonAsync<PostListDto>($"posts/search/?q={query}&limit={limit}&skip={skip}&delay={delay}");
        return response.Posts;
    }

    public async Task<Post> Get(int id, int delay = 0)
    {
        return await DummyJsonClient.GetFromJsonAsync<Post>($"posts/{id}?delay={delay}");
    }

    public async Task<Post> Create(Post post)
    {
        var response = await DummyJsonClient.PostAsJsonAsync("posts", post);
        return await response.Content.ReadFromJsonAsync<Post>();
    }

    public async Task Update(Post post)
    {
        await DummyJsonClient.PutAsJsonAsync($"posts/{post.Id}", post);
    }

    public async Task Delete(int id)
    {
        await DummyJsonClient.DeleteAsync($"posts/{id}");
    }
}