using AutoMapper;
using BlogApplication.Application.Features.Posts.Requests.Commands;
using BlogApplication.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlogApplication.Application.Features.Posts.Handlers.Commands
{

    public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;
        public DeletePostCommandHandler(IPostRepository postRepository, IMapper mapper)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }
        public async Task<Unit> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            var post = await _postRepository.GetDetail(request.Id);
            await _postRepository.Delete(post.Id);
            
            return Unit.Value;

        }
    }
}
