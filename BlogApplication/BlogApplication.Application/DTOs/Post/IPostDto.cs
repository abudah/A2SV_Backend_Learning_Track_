using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApplication.Application.DTOs.Post
{
    public interface IPostDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
