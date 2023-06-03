using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClientesRepository _clientesRepository;

        public HomeController(ILogger<HomeController> logger,
            IClientesRepository clientesRepository)
        {
            _logger = logger;
            _clientesRepository = clientesRepository;
        }

        public IActionResult Index()
        {
            return Json(_clientesRepository.ObterTodos());
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