using CustomerLogin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using NuGet.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace CustomerLogin.Controllers
{
    // [Authorize(Roles = "CUSTOMER")] // ... "ADMIN,RECEPTIONIST,COACH")] // do not allow this page without authorization; allow for customer role
    // but in this case Login page is authomatically called (don't know where this default behaviour is in the code)
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        [AllowAnonymous]
        public async Task<string> GetRoles(IdentityUser u)
        {
            string result = "";
            IList<string> roles = await _userManager.GetRolesAsync(u);
            foreach (var r in roles) result += r + " ";
            return result;
        }

        [AllowAnonymous]
        public IActionResult Index()
        // public async Task<IActionResult> Index() // use this for the example below
        {
            return View();

            /* this is an example how to get current user and the users list:
            IdentityUser user = await _userManager.GetUserAsync(HttpContext.User); // returns null if the user is not logged in
            IQueryable<IdentityUser> users = _userManager.Users;
            string text = "Current authorized user details:\n\n";
            if (user == null)
            {
                text += "User is not logged in";
            }
            else
            {
                string roles = await GetRoles(user);
                text += $"Id: {user.Id}\n"+
                    $"Roles: {roles}\n"+
                    $"UserName: {user.UserName}\n"+
                    $"Email: {user.Email}\n"+
                    $"EmailConfirmed: {user.EmailConfirmed}\n"+
                    $"PhoneNumber: {user.PhoneNumber}\n"+
                    $"PhoneNumberConfirmed: {user.PhoneNumberConfirmed}\n";
            }
            text += "\nList of all users:\n";
            foreach (IdentityUser u in users)
            {
                string roles = await GetRoles(u);
                text += $"Id: {u.Id} | Roles: {roles}| UserName: {u.UserName} | Email: {u.Email} | EmailConfirmed: {u.EmailConfirmed}"+
                    $"| PhoneNumber: {u.PhoneNumber} | PhoneNumberConfirmed: {u.PhoneNumberConfirmed}\n";
            }
            return Content(text);
            */
        }

        [Authorize(Roles = "Customer")] // ... "ADMIN,RECEPTIONIST,COACH")] // do not allow this page without authorization; allow for customer role 
        // [Authorize] // do not allow this page without authorization; allow for ANY role 
        public IActionResult Privacy()
        {
            return View();
            /* Authorize(Roles = "Customer") also can be done this way:
             * 
            var user = HttpContext.User.Identity; // var current_User = userManager.GetUserAsync(HttpContext.User);
            if (user.IsAuthenticated) // if user logged in and is CUSTOMER (if Auth. requires Customer, see Program.cs)
                return View(); // Show Privacy page
            else
                // return View("Denied"); // just show Denied page (with links to login and register pages) but don't change the URL in the address string
                return RedirectToAction("Denied", "Home"); // in this case we MOVE to the Denied page
            */
        }

        [AllowAnonymous]
        public IActionResult Denied()
        {

            // return RedirectToAction("Index", "Home");  // we can move to Home page here
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}