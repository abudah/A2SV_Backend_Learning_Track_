using BlogApplication.Application.DTOs.Post;
using BlogApplication.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApplication.Application.Features.Posts.Requests.Commands
{
    public class CreatePostCommand : IRequest<BaseCommandResponse>
    {
        public CreatePostDto CreatePostDto {  get; set; }
    }
}
