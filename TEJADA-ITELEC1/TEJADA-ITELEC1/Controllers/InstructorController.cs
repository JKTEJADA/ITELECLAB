using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using TEJADA_ITELEC1.Models;
using TEJADA_ITELEC1.DATA;



namespace TEJADA_ITELEC1.Controllers

{
    
    public class InstructorController : Controller
    {


        private readonly AppDbContext _dbContext;

        public InstructorController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.Instructors);
        }


        [HttpGet]
        public IActionResult addInstructor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult addInstructor(Instructor newInstructor)
        {
            _dbContext.Instructors.Add(newInstructor);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }



       


        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor!= null)//was an student found?
                return View(instructor);

            return NotFound();
        }

         [HttpGet]
        public IActionResult editDetail(int id)
        {

            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

        public IActionResult editDetail(Instructor newInstructor)
        {

            //Search for the student whose id matches the given id
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == newInstructor.Id);

            if (instructor != null)
            {
               instructor.FirstName = newInstructor.FirstName;
                instructor.LastName = newInstructor.LastName;
                instructor.isTenured = newInstructor.isTenured;
                instructor.Rank = newInstructor.Rank;
                instructor.Id = newInstructor.Id;
                instructor.HiringDate = newInstructor.HiringDate;

                _dbContext.SaveChanges();
                return RedirectToAction("Index");

            }


            return NotFound();

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {

            //Search for the student whose id matches the given id
            Instructor? instructor  = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            Console.WriteLine(instructor.Id);
            
            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();

        }


        [HttpPost]
        public IActionResult Delete(Instructor delinstructor)
        {

            //Search for the student whose id matches the given id
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == delinstructor.Id);
       

        

            if (instructor != null)
            {
                _dbContext.Instructors.Remove(instructor);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");

            }

            return NotFound();

        }

    }
}
