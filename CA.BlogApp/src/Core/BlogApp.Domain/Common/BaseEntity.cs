﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
