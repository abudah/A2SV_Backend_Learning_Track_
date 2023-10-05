using BlogApplication.Application.DTOs.Common;
using BlogApplication.Application.DTOs.Post;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApplication.Application.DTOs.Comment
{
    public class CommentDto : BaseDto
    {
        public int PostId { get; set; }
        public string Text { get; set; } = "";
    }
}
