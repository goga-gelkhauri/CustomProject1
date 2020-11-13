﻿using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Post : BaseEntity,IAggregateRoot
    {
        public string Name { get;  set; }
        public string Description { get;  set; }
        public int UserId { get;  set; }
    }
}
