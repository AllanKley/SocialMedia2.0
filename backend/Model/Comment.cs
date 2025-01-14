﻿using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int? CommentId { get; set; }
        public int? PostId { get; set; }

        public virtual Post? CommentPost { get; set; }
        public virtual Post? Post { get; set; }
    }
}
