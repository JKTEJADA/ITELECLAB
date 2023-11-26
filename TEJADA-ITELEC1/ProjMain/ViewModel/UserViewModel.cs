using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProjMain.ViewModel
{
    public class User
    {

        public int userID { get; set; }

        [Display(Name = "UserUserName")]
        public string userName { get; set; }

        [Display(Name = "UserEmail")]
        public string userEmail { get; set; }

        [Display(Name = "UserPassword")]
        [DataType(DataType.Password)]
        public string userPassword { get; set; }


    }
}
