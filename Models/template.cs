using System;
using ServiceStack.DataAnnotations;

namespace static_blog_core
{
    public class template
    {
        public int Id { get; set; }
        [References(typeof(templatetype))]
        public int TemplateTypeId { get; set; }
        [References(typeof(site))]
        public int SiteId { get; set; }
        [References(typeof(user))]
        public int CreatedBy { get; set; }
        [References(typeof(user))]
        public int LastModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }

        [Reference]
        public templatetype TemplateType { get; set; }
        [Reference]
        public site Site { get; set; }
        [Reference]
        public user CreatedByUser { get; set; }
        [Reference]
        public user LastModifiedByUser { get; set; }
    }
}