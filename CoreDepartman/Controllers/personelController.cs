using CoreDepartman.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDepartman.Controllers
{
    public class personelController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.personels.ToList();
            return View(degerler);
        }
    }
}
