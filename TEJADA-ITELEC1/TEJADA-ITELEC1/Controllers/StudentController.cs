
using Microsoft.AspNetCore.Mvc;
using TEJADA_ITELEC1.Models;
using TEJADA_ITELEC1.Services;

namespace TEJADA_ITELEC1.Controllers
{
   
        public class StudentController : Controller
        {
        private readonly fakeDTB _awitlods;
        
        public StudentController(fakeDTB awitlods)
        {
            _awitlods = awitlods;

        }
            

        



        public IActionResult Index()
        {
            return View(_awitlods.StudentList);
        }


        [HttpGet]
            public IActionResult AddStudent()
            {

                return View();
            }

        [HttpPost]
        public IActionResult AddStudent (Student newStudent)
        {
            _awitlods.StudentList.Add(newStudent);

            return RedirectToAction("Index");
        }


        public IActionResult ShowDetail(int id)
            {
                //Search for the student whose id matches the given id
                Student? student = _awitlods.StudentList.FirstOrDefault(st => st.Id == id);

                if (student != null)//was an student found?
                    return View(student);

                return NotFound();
            }



        [HttpGet]
        public IActionResult editDetail(int id)
        {

            //Search for the student whose id matches the given id
            Student? student = _awitlods.StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();

        }


        [HttpPost]
        public IActionResult editDetail(Student newStudent)
        {

            //Search for the student whose id matches the given id
            Student? student = _awitlods.StudentList.FirstOrDefault(st => st.Id == newStudent.Id);

            if (student != null)
            {
                student.Id = newStudent.Id;
                student.FirstName = newStudent.FirstName;
                student.LastName = newStudent.LastName;
                student.Email = newStudent.Email;
                student.GPA = newStudent.GPA;
             
                student.AdmissionDate = newStudent.AdmissionDate;
                student.Course = newStudent.Course;

                return RedirectToAction("Index");

            }

             
            return NotFound();

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {

            //Search for the student whose id matches the given id
            Student? student = _awitlods.StudentList.FirstOrDefault(st => st.Id == id);

            Console.WriteLine(student.Id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();

        }


        [HttpPost]
        public IActionResult Delete(Student delStudent)
        {

            //Search for the student whose id matches the given id
            var student = _awitlods.StudentList.FirstOrDefault(st => st.Id == delStudent.Id);

            Console.WriteLine(student);

            if (student != null)
            {
                _awitlods.StudentList.Remove(student);
                return View("Index", _awitlods.StudentList);

            }

            return NotFound();

        }






    }
}
