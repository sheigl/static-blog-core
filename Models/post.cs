using System;
using ServiceStack.DataAnnotations;

namespace static_blog_core
{
    public class post
    {
        public int Id { get; set; }
        [References(typeof(user))]
        public int CreatedBy { get; set; }
        [References(typeof(user))]
        public int LastModifiedBy { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public string Content { get; set; }

        [Reference]
        public user CreatedUser { get; set; }
        [Reference]
        public user LastModifiedUser { get; set; }
    }
}