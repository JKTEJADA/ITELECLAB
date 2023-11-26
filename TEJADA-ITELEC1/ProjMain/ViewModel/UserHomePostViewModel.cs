using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProjMain.ViewModel
{
    public class Homepage
    {

        public int postHomeID { get; set; }

        [Display(Name = "UserID")]
        public string? userID { get; set; }

        [Display(Name = "PostDate")]
        [DataType(DataType.DateTime)]
        public DateTime postHomeDate { get; set; }

        [Display(Name = "PostHome")]
        public string postHome { get; set; }


    }
}
