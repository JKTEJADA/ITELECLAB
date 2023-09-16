using Microsoft.AspNetCore.Mvc;
using TEJADA_MachProb1.Models;

namespace TEJADA_MachProb1.Controllers
{
    public class StudentController : Controller
    {
        List<Student> Students = new List<Student>
        {

             new Student()
            {


                FName = "Liek",
                LName = "Adajet",
                PGrade = 90,
                FGrade = 95


            },

              new Student()
            {


                FName = "Kiel",
                LName = "Tejada",
                PGrade = 76,
                FGrade = 74


            }
        };
        public IActionResult Index()
        {
            return View(Students);
        }
    }
}
