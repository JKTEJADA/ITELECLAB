using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProjMain.ViewModel
{
    public class Admin
    {

        public int adminID { get; set; }



        [Display(Name = "AdminUserName")]
        public string name { get; set; }

        [Display(Name = "AdminName")]
        public string adminName { get; set; }

        [Display(Name = "AdminEmail")]
        [DataType(DataType.EmailAddress)]
        public string adminEmail { get; set; }

        [Display(Name = "AdminEmail")]
        [DataType(DataType.Password)]
        public string adminPassword { get; set; }
    }
}
