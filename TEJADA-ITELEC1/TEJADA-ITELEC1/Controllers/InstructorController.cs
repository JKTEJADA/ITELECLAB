using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using TEJADA_ITELEC1.Models;
using TEJADA_ITELEC1.Services;

namespace TEJADA_ITELEC1.Controllers

{
    
    public class InstructorController : Controller
    { 
        
     
         private readonly fakeDTB _awitlods;

        public InstructorController(fakeDTB awitlods)
        {
            _awitlods = awitlods;

        }

        public IActionResult Index()
        {
            return View(_awitlods.InstructorList);
        }


        [HttpGet]
        public IActionResult addInstructor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult addInstructor(Instructor newInstructor)
        {
            _awitlods.InstructorList.Add(newInstructor);

            return RedirectToAction("Index");
        }



       


        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _awitlods.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor!= null)//was an student found?
                return View(instructor);

            return NotFound();
        }

         [HttpGet]
        public IActionResult editDetail(int id)
        {

            Instructor? instructor = _awitlods.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

        public IActionResult editDetail(Instructor newInstructor)
        {

            //Search for the student whose id matches the given id
            Instructor? instructor = _awitlods.InstructorList.FirstOrDefault(st => st.Id == newInstructor.Id);

            if (instructor != null)
            {
               instructor.FirstName = newInstructor.FirstName;
                instructor.LastName = newInstructor.LastName;
                instructor.isTenured = newInstructor.isTenured;
                instructor.Rank = newInstructor.Rank;
                instructor.Id = newInstructor.Id;
                instructor.HiringDate = newInstructor.HiringDate;


                return RedirectToAction("Index");

            }


            return NotFound();

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {

            //Search for the student whose id matches the given id
            Instructor? instructor  = _awitlods.InstructorList.FirstOrDefault(st => st.Id == id);

            Console.WriteLine(instructor.Id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();

        }


        [HttpPost]
        public IActionResult Delete(Instructor delinstructor)
        {

            //Search for the student whose id matches the given id
            Instructor? instructor = _awitlods.InstructorList.FirstOrDefault(st => st.Id == delinstructor.Id);
       

        

            if (instructor != null)
            {
                _awitlods.InstructorList.Remove(instructor);
                return RedirectToAction("Index");

            }

            return NotFound();

        }

    }
}
