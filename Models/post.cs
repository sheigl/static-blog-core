using System;

namespace static_blog_core
{
    public class post
    {
    public int Id { get; set; }
    public int CreatedBy { get; set; }
    public int LastModifiedBy { get; set; }
    public string Title { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime LastModifiedOn { get; set; }
    public string Content { get; set; }
    }
}