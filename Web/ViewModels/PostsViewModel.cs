﻿using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class PostsViewModel
    {
        public IReadOnlyList<Post> Posts { get; set; }
    }
}
