using LFL.AbpProject.Application.Contracts.Users;
using LFL.AbpProject.web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LFL.AbpProject.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserAppService _userService;

        public HomeController(ILogger<HomeController> logger, IUserAppService userService)
        {
            _logger = logger;
            this._userService = userService;
        }

        public IActionResult Index()
        {
            var user = _userService.GetUserAsync(123);
            Console.WriteLine("*************************");
            Console.WriteLine("*************************");
            Console.WriteLine($"This is {this.GetType().Name}{MethodInfo.GetCurrentMethod().Name} INvoke");
            Console.WriteLine($"{user.Result.UserName}");
            Console.WriteLine("*************************");
            Console.WriteLine("*************************");

            return View();
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
