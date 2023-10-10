using BlogApplication.Application.DTOs.Post;
using BlogApplication.Application.Features.Posts.Requests.Commands;
using BlogApplication.Application.Features.Posts.Requests.Queries;
using BlogApplication.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogApplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PostsController(IMediator mediator)
        {
            _mediator = mediator;   
        }
        // GET: api/<PostsController>
        [HttpGet]
        public async Task<ActionResult<Post>> Get()
        {
            var posts = await _mediator.Send(new GetPostListRequest());
            return Ok(posts);   
        }

        // GET api/<PostsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> Get(int id)
        {
            var post = await _mediator.Send(new GetPostDetailRequest { Id = id});
            return Ok(post);
        }

        // POST api/<PostsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreatePostDto Post)
        {
            var command = new CreatePostCommand { CreatePostDto = Post };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<PostsController>
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdatePostDto Post)
        {
            var command = new UpdatePostCommand { UpdatePostDto = Post };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<PostsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(PostDto Post)
        {
            var command = new DeletePostCommand { PostDto = Post};
            await _mediator.Send(command);  
            return NoContent();
        }
    }
}
