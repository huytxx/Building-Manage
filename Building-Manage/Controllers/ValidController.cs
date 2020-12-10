using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Building_Manage.Controllers
{
    public class ValidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
