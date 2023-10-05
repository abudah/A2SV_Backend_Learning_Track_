using BlogApplication.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApplication.Domain
{
    public class Post : BaseEntity
    {
        public Post()
        {
            Comments  = new HashSet<Comment>();
        }
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        public ICollection<Comment> Comments{ get; set;}
    }
}
