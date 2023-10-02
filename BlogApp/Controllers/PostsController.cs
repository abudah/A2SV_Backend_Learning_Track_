using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class PostsController : ControllerBase
{
	private static BlogContext _context;
	public PostsController(BlogContext context)
	{
		_context = context;
	}
	[HttpGet]
	public async Task<IActionResult>  Get()
	{
		var posts = await _context.Posts.ToListAsync();
		return Ok(posts);
	}	

	[HttpGet("{Id:int}")]
	public async Task<IActionResult>  Get(int Id)
	{
		var posts = await _context.Posts.FirstOrDefaultAsync(t => t.Id == Id);
		if(posts == null)
			return BadRequest("Invalid Id");
		return Ok(posts);
	}	

	[HttpPost]
	public async Task<IActionResult>  Post(Post post)
	{
		await _context.Posts.AddAsync(post);
		await _context.SaveChangesAsync();
		return CreatedAtAction("Get", post.Id, post);
	}	

	[HttpPatch]
	public async Task<IActionResult>  Patch(int Id, string content)
	{
		var post = await _context.Posts.FirstOrDefaultAsync(t => t.Id == Id);
		if(post == null)
			return BadRequest("Invalid Id");
		post.Content = content; 
		await _context.SaveChangesAsync();
		return NoContent();

	}	

	[HttpDelete]
	public async Task<IActionResult>  Delete(int Id)
	{
		var post = await _context.Posts.FirstOrDefaultAsync(t => t.Id == Id);
		if(post == null)
			return BadRequest("Invalid Id");
		_context.Posts.Remove(post);
		await _context.SaveChangesAsync();
		return NoContent();
	}		
}