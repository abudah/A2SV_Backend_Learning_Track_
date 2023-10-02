using Microsoft.EntityFrameworkCore;


public class BlogContext : DbContext
{
	public virtual DbSet<Post> Posts { get; set; }
	public virtual DbSet<Comment> Comments { get; set; }

	public BlogContext(DbContextOptions<BlogContext> options) : base(options)
	{
		
	}
	
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		    modelBuilder.Entity<Comment>()
				.HasOne(c => c.Post)
				.WithMany(p => p.Comments)
				.HasForeignKey(c => c.PostId);
	}
}