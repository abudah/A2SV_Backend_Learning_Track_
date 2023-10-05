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
    public class GetPostListRequestHandler : IRequestHandler<GetPostListRequest, List<PostDto>>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        
        public GetPostListRequestHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<List<PostDto>> Handle(GetPostListRequest request, CancellationToken cancellationToken)
        {
            var post = await _postRepository.GetList();

            return _mapper.Map<List<PostDto>>(post);
        }
    }
}
