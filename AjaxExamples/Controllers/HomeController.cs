using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AjaxExamples.Models;
using Newtonsoft.Json;

namespace AjaxExamples.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ListUser()
        {
            return Json(JsonConvert.SerializeObject(UserProcess.GetAllUser()));
        }



        [HttpPost]
        public IActionResult AddUser(User user)
        {
            UserProcess.AddUser(user);
     
            return Json(JsonConvert.SerializeObject(user));
        }
        public IActionResult GetUserbyID(int userid)
        {
            return Json(JsonConvert.SerializeObject(UserProcess.GetUserById(userid)));
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
    }
}
