using Microsoft.AspNetCore.Mvc;

namespace ProjMain.Models
{
    public class AdminQOTD
    {
        public int adminQotdID { get; set; }
        public string adminUserName { get; set; }
        public string adminQOTD { get; set; }

    }
}
