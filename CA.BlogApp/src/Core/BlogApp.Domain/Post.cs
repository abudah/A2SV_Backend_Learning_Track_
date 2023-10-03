﻿using BlogApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Domain
{
    public class Post : BaseEntity
    {
        public int PostId { get; set; }
        public string Text { get; set; } = "";
        public virtual Post post { get; set; }
    }
}
