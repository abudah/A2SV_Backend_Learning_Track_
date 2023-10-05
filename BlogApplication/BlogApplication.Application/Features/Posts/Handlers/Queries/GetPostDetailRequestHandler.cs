using AutoMapper;
using BlogApplication.Application.DTOs.Post;
using BlogApplication.Application.Features.Posts.Requests.Queries;
using BlogApplication.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlogApplication.Application.Features.Posts.Handlers.Queries
{
    public class GetPostDetailRequestHandler : IRequestHandler<GetPostDetailRequest, PostDto>
    {
        private readonly IMapper _mapper;   
        private readonly IPostRepository _postRepository;
        public GetPostDetailRequestHandler(IPostRepository postRepository, IMapper mapper)
        {
            _mapper = mapper;   
            _postRepository = postRepository;   
            
        }
        public async Task<PostDto> Handle(GetPostDetailRequest request, CancellationToken cancellationToken)
        {
            var post = await _postRepository.GetDetail(request.Id);
            
            return _mapper.Map<PostDto>(post);  
        }
    }
}
