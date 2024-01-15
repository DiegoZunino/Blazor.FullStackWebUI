namespace Blazor.FullStackWebUI.Shared.Dtos;

public class DummyJsonListDto
{
    public int Total { get; set; }
    public int Skip { get; set; }
    public int Limit { get; set; }
}

public class PostListDto : DummyJsonListDto
{
    public List<Post> Posts { get; set; }
}