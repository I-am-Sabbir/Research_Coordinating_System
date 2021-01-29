using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Membership.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Research_Coordinating_System.Models;

namespace Research_Coordinating_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Dashboard()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Name);
            if (userEmail == null)
            {
                return RedirectToAction("Index");
            }
            var user = await _userManager.FindByNameAsync(userEmail);
            var role = await _userManager.GetRolesAsync(user);
            if (role.Contains("Admin") == true)
            {
                _logger.LogInformation("User logged in.");
                return RedirectToAction("Index", "AdminDashboard", new { area = "Admin" });
            }
            else if (role.Contains("Coordinator") == true)
            {
                _logger.LogInformation("User logged in.");
                return RedirectToAction("Index", "CoordinatorDashboard", new { area = "Coordinator" });
            }
            else if (role.Contains("Faculty") == true)
            {
                _logger.LogInformation("User logged in.");
                return RedirectToAction("Index", "Dashboard", new { area = "" });
            }
            else
                return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ListUsers()
        {
            List<ApplicationUser> user = (from ApplicationUser in _userManager.Users
                                       select ApplicationUser).ToList();
            return Json(JsonConvert.SerializeObject(user));
        }

        public IActionResult Report()
        {
            return View();
        }
    }
}
