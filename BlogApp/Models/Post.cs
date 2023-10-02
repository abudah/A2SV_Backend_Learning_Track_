public class Post : BaseEntity
{
	public Post()
	{
		Comments = new HashSet<Comment>();
	}
	public string Content { get; set; } = "";
	public string Title { get; set; } = "";

	public ICollection<Comment> Comments { get; set; }
}