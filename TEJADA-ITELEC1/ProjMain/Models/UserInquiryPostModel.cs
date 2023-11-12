using Microsoft.AspNetCore.Mvc;

namespace ProjMain.Models
{
    public class Inquiry
    {

        public int postInqID { get; set; }
        public string userID { get; set; }
        public DateTime postInqDate { get; set; }
        public string postInq { get; set; }


    }
}
