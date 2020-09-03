using Microsoft.AspNetCore.Mvc;
using Lofter.Models;

namespace Lofter.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Authorize(TenantModel tenant)
        {
            //ToDo: Create User Database and look if User is registered via LINQ(?)
            TenantModel test_Tenant = new TenantModel { EmailAddress = "Test@web.de", Password = "Test123" };
            if (tenant.EmailAddress != test_Tenant.EmailAddress ||
                tenant.Password != test_Tenant.Password)
            {
                if (tenant.EmailAddress != null || tenant.Password != null)
                {
                    tenant.ErrorMessage = "Wrong Email or Password";
                }
                return View("Index", tenant);
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