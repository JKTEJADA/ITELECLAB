using IdentityUSER.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityUSER.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<UserClass> _signInManager;
        public AccountController(SignInManager<UserClass> signInManager)
        {
            _signInManager = signInManager;
        }

        // GET: /<controller/


        public IActionResult login()
        {
            return View();
        }
    }
}
