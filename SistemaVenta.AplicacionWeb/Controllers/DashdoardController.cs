using Microsoft.AspNetCore.Mvc;

namespace SistemaVenta.AplicacionWeb.Controllers
{
    public class DashdoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
