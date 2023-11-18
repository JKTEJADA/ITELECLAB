namespace TEJADA_ITELEC1.DATA { 


using Microsoft.AspNetCore.Identity;

    public class UserClass : IdentityUser
    {
        internal string? FirstName;
        internal string? Lastname;

        public string? UserName { get; set; }
        public string? Password { get; set;}
        public bool? RememberMe { get; set; }

    }
}
