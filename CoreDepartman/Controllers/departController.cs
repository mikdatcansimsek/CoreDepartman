using Microsoft.AspNetCore.Mvc;
using CoreDepartman.Models;
namespace CoreDepartman.Controllers
{
    public class departController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.departmanlars.ToList();

            return View(degerler);
        }

    }
}
