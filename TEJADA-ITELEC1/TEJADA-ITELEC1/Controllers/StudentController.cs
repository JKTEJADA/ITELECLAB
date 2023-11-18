
using Microsoft.AspNetCore.Mvc;
using TEJADA_ITELEC1.Models;
using TEJADA_ITELEC1.DATA;
using System;

namespace TEJADA_ITELEC1.Controllers
{
   
        public class StudentController : Controller
        {
        private readonly AppDbContext _dbContext;

        public StudentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult Index()
        {
            return View(_dbContext.Roster);
        }


        [HttpGet]
            public IActionResult AddStudent()
            {

                return View();
            }

        [HttpPost]
        public IActionResult AddStudent (Student newStudent)
        {
            if (!ModelState.IsValid)
                return View();
            _dbContext.Roster.Add(newStudent);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult ShowDetail(int id)
            {
                //Search for the student whose id matches the given id
                Student? student = _dbContext.Roster.FirstOrDefault(st => st.Id == id);

                if (student != null)//was an student found?
                    return View(student);

                return NotFound();
            }



        [HttpGet]
        public IActionResult editDetail(int id)
        {

            //Search for the student whose id matches the given id
            Student? student = _dbContext.Roster.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();

        }


        [HttpPost]
        public IActionResult editDetail(Student newStudent)
        {

            //Search for the student whose id matches the given id
            Student? student = _dbContext.Roster.FirstOrDefault(st => st.Id == newStudent.Id);

            if (student != null)
            {
                student.Id = newStudent.Id;
                student.FirstName = newStudent.FirstName;
                student.LastName = newStudent.LastName;
                student.Email = newStudent.Email;
                student.GPA = newStudent.GPA;
             
                student.AdmissionDate = newStudent.AdmissionDate;
                student.Course = newStudent.Course;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");

            }

             
            return NotFound();

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {

            //Search for the student whose id matches the given id
            Student? student = _dbContext.Roster.FirstOrDefault(st => st.Id == id);

            Console.WriteLine(student.Id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();

        }


        [HttpPost]
        public IActionResult Delete(Student delStudent)
        {

            //Search for the student whose id matches the given id
            var student = _dbContext.Roster.FirstOrDefault(st => st.Id == delStudent.Id);

            Console.WriteLine(student);

            if (student != null)
            {
                _dbContext.Roster.Remove(student);
                _dbContext.SaveChanges();
                return View("Index", _dbContext.Roster);

            }

            return NotFound();

        }






    }
}
