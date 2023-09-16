using Microsoft.AspNetCore.Mvc;

namespace TEJADA_MachProb1.Models
{
    public class Instructor
    {

        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsTenured {get; set;}
        public int SalaryPerHour { get; set; }
        public string Email { get; set; }

        
    }

   
}
