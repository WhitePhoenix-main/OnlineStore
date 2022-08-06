using Microsoft.AspNetCore.Identity;

namespace PizzaStore
{
    public class SiteUsers : IdentityUser
    {
        public int Age { get; set; }
    }
}