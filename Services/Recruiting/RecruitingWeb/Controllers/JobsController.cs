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
    public async Task<IActionResult> Index()
    {
        ViewBag.PageTitle = "Showing Jobs";
        var jobs = await jobService.GetAllJobs();
        return View(jobs);
    }
    [HttpGet]
    public async Task<IActionResult> Details(int id)
    {
        var job = await jobService.GetJobById(id);
        return View();
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
}
