using ApplicationCore.Contracts.Services;
using Infrustructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace RecruitingWeb.Controllers;

public class JobsController : Controller
{
    private readonly IJobService jobService;

    public JobsController(IJobService jobService)
    {
        this.jobService = jobService;
    }
    [HttpGet]
    public IActionResult Index()
    {
        var jobs = jobService.GetAllJobs();
        return View();
    }
    [HttpGet]
    public IActionResult Details(int id)
    {
        var job = jobService.GetJobById(id);
        return View();
    }
    [HttpPost]
    public IActionResult Create()
    {
        return View();
    }
}
