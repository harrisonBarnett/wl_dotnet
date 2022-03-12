using Microsoft.AspNetCore.Mvc;

namespace wl_dotnet.Controllers
{
    public class Router : Controller
    {
        // GET: /Home/
        // TODO: design home view with tabs for options, stats, home
        public IActionResult Index()
        {
            return View();
        }
        // GET: /Login/
        // TODO: design login view with username/password fields
        public IActionResult Login()
        {
            return View();
        }
        //
        // TODO: write POST operation for Login()
        //
        // GET: /SignUp/
        // TODO: design signup view with email, username, password fields
        public IActionResult SignUup()
        {
            return View();
        }
        //
        // TODO: write POST operation for SignUp()
        //

        // GET: /Options/
        // TODO: design options view to include 1RM fields, reset data, download data
        public IActionResult Options()
        {
            return View();
        }
        // POST: /Options/
        // 
        // TODO: write POST operations to delete user data, download user data, update 1RM
        //

        // GET: /Stats/
        // TODO: design stats view to show line graph of lifts
        public IActionResult Stats()
        {
            return View();
        }
    }
}
