using System;
using ServiceStack.DataAnnotations;

namespace static_blog_core
{
    public class postcategory
    {
        public int Id { get; set; }
        [References(typeof(post))]
        public int PostId { get; set; }
        [References(typeof(category))]
        public int CategoryId { get; set; }
        [References(typeof(user))]
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        [Reference]
        public post Post { get; set; }
        [Reference]
        public category Category { get; set; }
        [Reference]
        public user CreatedByUser { get; set; }
    }
}