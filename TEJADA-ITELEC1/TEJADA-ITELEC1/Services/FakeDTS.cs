using TEJADA_ITELEC1.Models;
using TEJADA_ITELEC1.Services;


namespace TEJADA_ITELEC1.Services
{

    public class FakeDTS : fakeDTB
    {
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }


        public FakeDTS()
        {

            StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "ghaby021@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Montano", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1, Email = "zyx@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Montano", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "aerdriel@gmail.com"
                }
            };


            InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,
                    FirstName = "Barbie",
                    LastName = "Batumbakal",
                    isTenured = true,
                    Rank = Rank.Professor,
                    HiringDate = DateTime.Parse("1999-09-11"),


                },
                new Instructor()
                {
                    Id= 2,
                    FirstName = "Cena",
                    LastName = "John",
                    isTenured = false,
                    Rank = Rank.AssistantProfessor,
                    HiringDate = DateTime.Parse("1999-09-11"),


                },

                new Instructor()
                {
                    Id= 3,
                    FirstName = "Brendon",
                    LastName = "Labrador",
                    isTenured = true,
                    Rank = Rank.AssociateProfessor,
                    HiringDate = DateTime.Parse("1999-09-11"),


                },

            };

            }

        }
    }




