using BlogApplication.Application.Persistence.Contracts;
using FluentValidation;
using FluentValidation.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApplication.Application.DTOs.Post.Validators
{
    public class UpdatePostDtoValidator : AbstractValidator<UpdatePostDto>
    {
        private readonly IPostRepository _postRepository;
        public UpdatePostDtoValidator(IPostRepository postRepository)
        {
            _postRepository = postRepository;

            Include(new IPostDtoValidator());

            RuleFor(p => p.Id)
                .NotNull().WithMessage("{PropertyName} must be present")
                .MustAsync(async (id, token) =>
                {
                    var post = await _postRepository.GetDetail(id);
                    return post != null;
                });

            
        }
    }
}
