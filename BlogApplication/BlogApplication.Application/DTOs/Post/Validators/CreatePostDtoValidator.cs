using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BlogApplication.Application.DTOs.Post.Validators
{
    public class CreatePostDtoValidator : AbstractValidator<CreatePostDto>
    {
        public CreatePostDtoValidator()
        {
            Include(new IPostDtoValidator());
        }
    }
}
