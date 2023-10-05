using BlogApplication.Application.DTOs.Comment;
using BlogApplication.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApplication.Application.DTOs.Post
{
    public class CreatePostDto 
    {
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        public object Id { get; internal set; }
    }
}
