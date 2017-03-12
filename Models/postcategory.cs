using System;

namespace static_blog_core
{
    public class postcategory
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public int CategoryId { get; set; }
    public int CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    }
}