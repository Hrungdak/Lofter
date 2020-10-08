using Microsoft.AspNetCore.Mvc;
using Lofter.Models;

namespace Lofter.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View(new UserLoginViewData { Title = "User Login" });
        }

        [HttpPost]
        public IActionResult Authorize(UserLoginViewData user)
        {
            // Question: Validation Controller? -> seperate from Controller
            // 1. bei LoginButton Validation Controller aufrufen und den User als Parameter übergeben (wie hier)
            // 2. Im Validation Controller wird Validierung durchgeführt
            // 3. Falls erfolgreich -> Login Controller aufrufen

            //ToDo: Create User Database and look if User is registered via LINQ(?)
            UserLoginViewData test_user = new UserLoginViewData { EmailAddress = "Test@web.de", Password = "123" };
            if (user.EmailAddress != test_user.EmailAddress ||
                user.Password != test_user.Password)
            {
                if (user.EmailAddress != null && user.Password != null)
                {
                    user.ErrorMessage = "Wrong Email or Password";
                }
                return View("Index", user);
            }
            else
            {
                //ToDo: Log in User.
                //Session["TenantID"] = test_Tenant.TenantID;

                return RedirectToAction("Index", "Home");
                //return View("Session");

                //return Content("Logged in! But Work in Progress");
            }
        }

        public IActionResult Session()
        {
            return View();
        }
    }
}