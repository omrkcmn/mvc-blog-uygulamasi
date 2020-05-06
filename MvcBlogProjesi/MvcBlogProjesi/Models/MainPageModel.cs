using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBlogProjesi.Models
{
    public class MainPageModel
    {
        public IEnumerable<Blog> blog { get; set; }
        public IEnumerable<Comment> comment { get; set; }
    }
}