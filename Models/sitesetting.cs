using ServiceStack.DataAnnotations;

namespace static_blog_core
{
    public class sitesetting
    {
        public int Id { get; set; }
        [References(typeof(site))]
        public int SiteId { get; set; }
        public string TagLine { get; set; }
        public string Url { get; set; }
        public string Timezone { get; set; }

        [Reference]
        public site Site { get; set; }
    }
}