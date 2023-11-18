using TEJADA_ITELEC1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace TEJADA_ITELEC1.DATA
{
    public class AppDbContext: IdentityDbContext<UserClass>
    {



        public DbSet<Student> Roster { get; set; }
        public DbSet<Instructor> Instructors { get; set; }



        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor
                {
                    Id = 1,
                    FirstName = "Test",
                    LastName = "Test",
                    isTenured = true,
                    HiringDate = DateTime.Now,
                    Rank = Rank.Instructor,
                    UnusedPassword = "123",
                    PersonalURL = "123",
                    EmailAddress = "kjlkj",
                    PhoneNumber = "1234567890"


                },

                new Instructor
                {
                    Id = 2,
                    FirstName = "Test2",
                    LastName = "Test2",
                    isTenured = false,
                    HiringDate = DateTime.Now,
                    Rank = Rank.Instructor,
                    UnusedPassword = "1213",
                    PersonalURL = "123",
                    EmailAddress = "fhf",
                    PhoneNumber = "1234567890"
                }
                );

            modelBuilder.Entity<Student>().HasData(
               new Student
               {
                   Id = 1,
                   FirstName = "Test",
                   LastName = "Test",
                   GPA = 5.0,
                   Course = Course.BSIS,
                   AdmissionDate = DateTime.Now,

                   Email = "Test"


               });



        }

    }
}
        


