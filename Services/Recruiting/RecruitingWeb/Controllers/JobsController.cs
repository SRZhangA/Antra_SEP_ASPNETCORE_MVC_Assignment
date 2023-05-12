using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
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
        return View(job);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(JobRequestModel model)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        await jobService.AddJob(model);
        return RedirectToAction("Index");
    }
}
