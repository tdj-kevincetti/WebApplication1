using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginCtrl : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProcessLogin(Staff staffd)
        {
            if (staffd.Username == "FrancisPD" && staffd.Password=="Kuy"){
                return View("managetableUI", staffd);
            }
            else
            {
                return View("LoginFailure", staffd);
            }
        }
    }
}
