using GestaoFinanceira.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GestaoFinanceira.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
