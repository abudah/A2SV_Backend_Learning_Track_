using AutoMapper;
using BlogApplication.Application.DTOs.Post.Validators;
using BlogApplication.Application.Exceptions;
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
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;
        public UpdatePostCommandHandler(IPostRepository postRepository, IMapper mapper)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }

        public async Task<Unit> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdatePostDtoValidator(_postRepository);
            var validationResult = await validator.ValidateAsync(request.UpdatePostDto);

            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);

            var post = await _postRepository.GetDetail(request.UpdatePostDto.Id);
            _mapper.Map(request.UpdatePostDto, post);
            await _postRepository.Update(post);
            return Unit.Value;
        }
    }
}
