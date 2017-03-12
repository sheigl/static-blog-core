using System;

namespace static_blog_core
{
    public class template
    {
        public int Id { get; set; }
        public int TemplateTypeId { get; set; }
        public int SiteId { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}