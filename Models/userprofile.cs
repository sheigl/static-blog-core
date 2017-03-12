using ServiceStack.DataAnnotations;

namespace static_blog_core
{
    public class userprofile
    {
        public int Id { get; set; }
        [References(typeof(user))]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        
        [Reference]
        public user User { get; set; }
    }
}