using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application.Models;
using ORM.Interfaces;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Injeção de dependência (Tira a responsabilidade de ele ser instânciado | não precisa ser instânciado)
        private readonly ITodoRepository _todoRepository;

        public HomeController(ITodoRepository todoRepository)
        {
            // _logger = logger;
            _todoRepository = todoRepository;
        }

        public IActionResult Index()
        {
            var resultado = _todoRepository.GetAll();
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
