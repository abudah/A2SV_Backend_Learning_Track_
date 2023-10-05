using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApplication.Application.Features.Posts.Requests.Commands
{
    public class DeletePostCommand : IRequest
    {
        public int Id { get; set; }
    }
}
