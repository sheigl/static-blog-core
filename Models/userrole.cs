using ServiceStack.DataAnnotations;

namespace static_blog_core
{
    public class userrole
    {
        public int Id { get; set; }
        [References(typeof(user))]
        public int UserId { get; set; }
        [References(typeof(role))]
        public int RoleId { get; set; }

        [Reference]
        public user User { get; set; }
        [Reference]
        public role Role { get; set; }
    }
}