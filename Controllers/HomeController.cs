// Required namespaces for the controller functionality
using Microsoft.AspNetCore.Mvc;
using AspNetCoreApp.Models;
using System.Diagnostics;

namespace AspNetCoreApp.Controllers
{
    /// <summary>
    /// HomeController handles the main application routes and actions
    /// This controller is responsible for serving the home page, privacy page, and error handling
    /// </summary>
    public class HomeController : Controller
    {
        // Logger instance for recording diagnostic information
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// Constructor that initializes the controller with a logger instance
        /// </summary>
        /// <param name="logger">Logger instance injected by the dependency injection system</param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Handles requests to the home page (/)
        /// </summary>
        /// <returns>The Index view</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Handles requests to the privacy page (/Home/Privacy)
        /// </summary>
        /// <returns>The Privacy view</returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Handles error requests and displays the error page
        /// The ResponseCache attribute prevents caching of this page
        /// </summary>
        /// <returns>The Error view with error details</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Create and return an ErrorViewModel with the current request ID
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}