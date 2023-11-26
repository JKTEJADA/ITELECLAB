using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProjMain.ViewModel
{
    class InquiryComment
    {
        public string commentID { get; set; }


        public int commentInqID { get; set; }

        [Display(Name = "CommentInqID")]
        [DataType(DataType.DateTime)]
        public DateTime postInqComDate { get; set; }

        [Display(Name = "UserUserName")]
        public string username { get; set; }

        [Display(Name = "UserComment")]
        public string comment { get; set; }
    }
}
