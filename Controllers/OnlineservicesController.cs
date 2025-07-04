using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using yogloansdotnet.Models;

namespace yogloansdotnet.Controllers
{
    public class OnlineservicesController : Controller
    {
        private readonly ILogger<AboutController> _logger;

        public OnlineservicesController(ILogger<AboutController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
          
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel 
            { 
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier 
            });
        }
        [Route("payonline")]
        public IActionResult Payonline(string CustomerId, string mobile)
        {
            ViewBag.CustomerId = CustomerId;
            ViewBag.mobile = mobile;
            return View("~/Views/Payonline/index.cshtml", ViewBag);
        }
    }
}
