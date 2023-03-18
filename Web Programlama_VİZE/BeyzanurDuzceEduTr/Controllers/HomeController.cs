using BeyzanurDuzceEduTr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BeyzanurDuzceEduTr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        BeyzanurDuzceEduTrContext _ctx;

        public HomeController(ILogger<HomeController> logger, BeyzanurDuzceEduTrContext context)
        {
            _logger = logger;
            _ctx = context;
        }
       
        public IActionResult Index()
        {

            return View(_ctx.Announcements.ToList());
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Detail(int Id)
        {
            return View(_ctx.Announcements.Find(Id));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
