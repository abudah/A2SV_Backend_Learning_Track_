using BlogApplication.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApplication.Application.DTOs.Post
{
    public class UpdatePostDto : BaseDto
    {
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
    }
}
