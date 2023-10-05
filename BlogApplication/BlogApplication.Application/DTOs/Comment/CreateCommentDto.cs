using BlogApplication.Application.DTOs.Common;
using BlogApplication.Application.DTOs.Post;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApplication.Application.DTOs.Comment
{
    public class CreateCommentDto
    {
        public string Text { get; set; } = "";
    }
}
