using Microsoft.AspNetCore.Mvc;

namespace ProjMain.Models
{
    public class Homepage
    {

        public int postHomeID { get; set; }
        public string userID { get; set; }
        public DateTime postHomeDate { get; set; }
        public string postHome { get; set; }


    }
}
