using Microsoft.AspNetCore.Mvc;

namespace BMS.API.Controllers.Security
{
    public class UserAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
