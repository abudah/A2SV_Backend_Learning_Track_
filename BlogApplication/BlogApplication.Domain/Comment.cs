using BlogApplication.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApplication.Domain
{
    public class Comment : BaseEntity
    {
        public int PostId { get; set; }
        public string Text { get; set; } = "";
        public virtual Post post { get; set; }
    }
}
