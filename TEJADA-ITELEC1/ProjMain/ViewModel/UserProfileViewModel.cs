using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProjMain.ViewModel
{
    public class UserProfileViewModel
    {

        public int userProfileID { get; set; }


        public string userID { get; set; }

        [Display(Name = "UserUserName")]
        public string userName { get; set; }

        [Display(Name = "UserCollege")]
        public string userCollege { get; set; }

        [Display(Name = "UserBio")]
        public string? userBio { get; set; }

    }
}
