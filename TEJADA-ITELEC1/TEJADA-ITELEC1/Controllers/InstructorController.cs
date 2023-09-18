using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using TEJADA_ITELEC1.Models;

namespace TEJADA_ITELEC1.Controllers

{
    
    public class InstructorController : Controller
    { 
        
        List<Instructor> InstructorList = new List<Instructor>
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

        public IActionResult Index()
        {
            return View(InstructorList);
        }


        [HttpGet]
        public IActionResult addInstructor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult addInstructor(Instructor newInstructor)
        {
            InstructorList.Add(newInstructor);

            return View("Index",InstructorList);
        }



       


        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor!= null)//was an student found?
                return View(instructor);

            return NotFound();
        }

         [HttpGet]
        public IActionResult editDetail(int id)
        {

            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

        public IActionResult editDetail(Instructor newInstructor)
        {

            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == newInstructor.Id);

            if (instructor != null)
            {
               instructor.FirstName = newInstructor.FirstName;
                instructor.LastName = newInstructor.LastName;
                instructor.isTenured = newInstructor.isTenured;
                instructor.Rank = newInstructor.Rank;
                instructor.Id = newInstructor.Id;
                instructor.HiringDate = newInstructor.HiringDate;
          

                return View("Index", InstructorList);

            }


            return NotFound();

        }

    }
}
