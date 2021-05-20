using Stock_EQ_API_DataBaseContext.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("/prefijos")]
        public IActionResult prefijos()
        {
            return View();
        }

        [Route("/empresas")]
        public IActionResult empresas()
        {
            return View();
        }
    }
}
