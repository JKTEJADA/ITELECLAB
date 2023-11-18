using Microsoft.AspNetCore.Identity;

namespace IdentityUSER.Data
{
    public class UserClass: IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
