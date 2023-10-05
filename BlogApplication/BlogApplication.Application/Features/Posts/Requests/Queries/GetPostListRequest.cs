using BlogApplication.Application.DTOs.Post;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApplication.Application.Features.Posts.Requests.Queries
{
    public class GetPostListRequest : IRequest<List<PostDto>>
    {

    }
}
