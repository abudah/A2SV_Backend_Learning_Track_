using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class CommentsController : ControllerBase
{
	private static BlogContext _context;
	public CommentsController(BlogContext context)
	{
		_context = context;
	}
	[HttpGet]
	public async Task<IActionResult>  Get()
	{
		var comments = await _context.Comments.ToListAsync();
		return Ok(comments);
	}	

	[HttpPost]
	public async Task<IActionResult>  Post(Comment	comment)
	{
		await _context.Comments.AddAsync(comment);
		await _context.SaveChangesAsync();
		return CreatedAtAction("Get", comment.Id, comment);
	}	

	[HttpPatch]
	public async Task<IActionResult>  Patch(int Id, string text)
	{
		var  comment = await _context.Comments.FirstOrDefaultAsync(t => t.Id == Id);
		if(comment == null)
			return BadRequest("Invalid Id");
		comment.Text = text; 
		await _context.SaveChangesAsync();
		return NoContent();

	}	

	[HttpDelete]
	public async Task<IActionResult>  Delete(int Id)
	{
		var comment = await _context.Comments.FirstOrDefaultAsync(t => t.Id == Id);
		if(comment == null)
			return BadRequest("Invalid Id");
		_context.Comments.Remove(comment);
		await _context.SaveChangesAsync();
		return NoContent();
	}		
}