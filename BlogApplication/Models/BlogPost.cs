﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApplication.Models
{
    public class BlogPost
    {
        public BlogPost()
        {
            this.Comments = new HashSet<Comment>();

        }

        public int Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        [AllowHtml]
        public string Body { get; set; }
        public string MediaURL { get; set; }
        public object MediaUrl { get; internal set; }
        public bool Published { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}