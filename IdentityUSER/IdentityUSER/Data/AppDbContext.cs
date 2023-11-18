using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityUSER.Data
{
    public class AppDbContext : IdentityDbContext<UserClass>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {


        }
    }   
}