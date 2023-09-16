using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using TEJADA_MachProb1.Models;

namespace TEJADA_MachProb1.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> Instructors = new List<Instructor>
        {
            new Instructor()
            { 
                FName = "Kiel",
                LName = "Tejada",
                Birthday = new DateTime(2002, 07, 25),
                IsTenured = true,
                SalaryPerHour = 200,
                Email = "jktejada@ust.edu.com"
                
            },
             new Instructor()
            {


                FName = "Liek",
                LName = "Adajet",
                Birthday = new DateTime(2000, 07, 24),
                IsTenured = false,
                SalaryPerHour = 200,
                Email = "jladajet@yahoo.com"

            }



        };


      
        

        public IActionResult Index()
        {   
            return View(Instructors);
            
        }
    }
}
