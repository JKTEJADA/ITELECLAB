using Microsoft.AspNetCore.Mvc;

namespace ProjMain.Models
{
    class InquiryComment
    {
        public string commentID { get; set; }
        public int commentInqID { get; set; }
        public DateTime postInqComDate { get; set; }
        public string username { get; set; }
        public string comment { get; set; }
    }
}
