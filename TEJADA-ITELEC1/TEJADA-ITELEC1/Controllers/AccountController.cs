using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TEJADA_ITELEC1.DATA;
using TEJADA_ITELEC1.ViewModel;

namespace TEJADA_ITELEC1.Controllers
{
    public class AccountController : Controller
    {

       private readonly SignInManager<UserClass> _signInManager;
       private readonly UserManager<UserClass> _userManager;

      
        public AccountController(SignInManager<UserClass> signInManager, UserManager<UserClass> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        //GET : /<controller>/


        [HttpGet]
        public IActionResult Login()
        {
            return View("Index");
        }



        [HttpPost]
        private async Task<IActionResult> Login(LoginViewModel loginInfo)
        {
            var result = await _signInManager.PasswordSignInAsync(loginInfo.UserName,
                                                                  loginInfo.Password,
                                                                  loginInfo.RememberMe,
                                                                  false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Instructor");
            }
            else
            {
                ModelState.AddModelError("", "Failed to Login");
            }

            return View(loginInfo);
        }

        private async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Instructor");   
        }

        [HttpGet]
       public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel userEnteredData)
        {
            if(!ModelState.IsValid) 
            {
                UserClass newUser = new()
                {
                    UserName = userEnteredData.Name,
                    FirstName = userEnteredData.FirstName,
                    Lastname = userEnteredData.LastName,
                    Email = userEnteredData.EmailAddress,
                    PhoneNumber = userEnteredData.PhoneNumber
                };

                var result = await _userManager.CreateAsync(newUser,userEnteredData.Password);
                
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Instructor");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }

               
            }

            return View(userEnteredData);
        }
    }

   

    
}


