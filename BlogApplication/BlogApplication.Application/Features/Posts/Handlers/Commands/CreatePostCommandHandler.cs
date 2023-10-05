using AutoMapper;
using BlogApplication.Application.Features.Posts.Requests.Commands;
using BlogApplication.Application.Persistence.Contracts;
using BlogApplication.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlogApplication.Application.Features.Posts.Handlers.Commands
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;
        public CreatePostCommandHandler(IPostRepository postRepository, IMapper mapper)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }
        public async Task<int> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = _mapper.Map<Post>(request.CreatePostDto);
            post = await _postRepository.Add(post);
            
            return post.Id;
        }
    }
}
