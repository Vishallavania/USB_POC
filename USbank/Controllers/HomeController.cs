using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using USbank.Models;

namespace USbank.Controllers
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

        [HttpPost]
        public JsonResult AddCTR(string txtCTRNbr, string txtComfirmCTRNbr, string txtTranDate, string txtBusinessline)
        {
            
            return Json("Got this"+txtCTRNbr);
        }
        [HttpPost]
        public JsonResult AddIssue(string txtCTRLogNbr, string txtCustomerType, string txtIssue, string txtIssueType)
        {

            return Json("Got this" + txtCTRLogNbr);
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
