using System;
using System.Collections.Generic;

namespace FacebookClone.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public Post ParentId { get; set; }
        public ApplicationUser UserId { get; set; }
        public string Content { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public DateTime CreatedOn  { get; set; }
        public DateTime ModifiedOn  { get; set; }
        public ICollection<Post> ChildPost { get; set; }
    }
}