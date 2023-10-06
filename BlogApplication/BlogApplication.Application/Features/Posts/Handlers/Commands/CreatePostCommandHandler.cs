using AutoMapper;
using BlogApplication.Application.DTOs.Post.Validators;
using BlogApplication.Application.Exceptions;
using BlogApplication.Application.Features.Posts.Requests.Commands;
using BlogApplication.Application.Persistence.Contracts;
using BlogApplication.Application.Responses;
using BlogApplication.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlogApplication.Application.Features.Posts.Handlers.Commands
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, BaseCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;
        public CreatePostCommandHandler(IPostRepository postRepository, IMapper mapper)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }
        public async Task<BaseCommandResponse> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();

            var validator = new CreatePostDtoValidator();
            var validationResult = await validator.ValidateAsync(request.CreatePostDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }

            var post = _mapper.Map<Post>(request.CreatePostDto);
            post = await _postRepository.Add(post);
            response.Success = true;
            response.Message = "Creation Successful";
            response.Id = post.Id;

            return response;
        }
    }
}
