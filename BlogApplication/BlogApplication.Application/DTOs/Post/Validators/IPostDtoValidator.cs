using BlogApplication.Application.Persistence.Contracts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApplication.Application.DTOs.Post.Validators
{
    public class IPostDtoValidator : AbstractValidator<IPostDto>
    {
        public IPostDtoValidator()
        {            
            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(p => p.Content)
                 .NotEmpty().WithMessage("{PropertyName} is required.")
                 .NotNull();
        }
    }
}
