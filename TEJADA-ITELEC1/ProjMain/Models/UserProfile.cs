using Microsoft.AspNetCore.Mvc;

namespace ProjMain.Models
{
    public class UserProfile
    {

        public int userProfileID { get; set; }
        public string userID { get; set; }
        public string userName { get; set; }
        public string userCollege { get; set; }
        public string userBio { get; set; }

    }
}
