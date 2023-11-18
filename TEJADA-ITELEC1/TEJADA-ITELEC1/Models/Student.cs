using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TEJADA_ITELEC1.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }

    public class Student
    {

        public int Id { get; set; }

        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Display(Name = "GPA")]
        public double GPA { get; set; }

        [Display(Name = "Course")]
        public Course Course { get; set; }

        [Display(Name = "AdmissionDate")]
        public DateTime AdmissionDate { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

    }
}
