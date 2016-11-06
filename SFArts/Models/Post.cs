using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SFArts.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string ImageUri { get; set; }   
        public Category Category { get; set; }
        public string Content { get; set; }
    }
}