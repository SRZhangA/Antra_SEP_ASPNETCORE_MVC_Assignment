using Microsoft.AspNetCore.Mvc;

namespace RecruitingWeb.Controllers
{
    public class JobsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }
    }
}
