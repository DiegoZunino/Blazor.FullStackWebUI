namespace Blazor.FullStackWebUI.Shared.Interfaces;

public interface IDummyJsonService<T>
{
    public Task<List<T>> GetList(int limit = 0, int skip = 0, int delay = 0);
    
    public Task<List<T>> Search(string query, int limit = 0, int skip = 0, int delay = 0);

    public Task<T> Get(int id, int delay = 0);

    public Task<T> Create(Post post);

    public Task Update(T post);

    public Task Delete(int id);
}