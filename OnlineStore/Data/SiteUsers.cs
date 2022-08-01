using Microsoft.AspNetCore.Identity;

namespace OnlineStore
{
    public class SiteUsers : IdentityUser
    {
        public int Age { get; set; }
    }
}