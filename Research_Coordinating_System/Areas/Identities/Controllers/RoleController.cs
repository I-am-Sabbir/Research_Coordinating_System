using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Research_Coordinating_System.Areas.Identities.Controllers
{
    public class RoleController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
