using Microsoft.AspNetCore.Mvc;
using SOLUTIONS.GALAXY.Application.Interfaces;

namespace SOLUTIONS.GALAXY.Web.Controllers
{
    public class HologramsController : Controller
    {
        private readonly IHologramsApp hologramsApp;
        public HologramsController(IHologramsApp _hologramsApp)
        {
            hologramsApp = _hologramsApp;
        }
        public IActionResult Index()
        {
            var holograms = hologramsApp.GetAll();
            return View(holograms);
        }
    }
}