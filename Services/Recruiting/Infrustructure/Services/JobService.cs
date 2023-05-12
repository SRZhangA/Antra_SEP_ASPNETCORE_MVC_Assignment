using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace Infrustructure.Services;

public class JobService : IJobService
{
    private readonly IJobRepository jobRepository;

    public JobService(IJobRepository jobRepository)
    {
        this.jobRepository = jobRepository;
    }

    public async Task<int> AddJob(JobRequestModel model)
    {
        var jobEntity = new Job()
        {
            Description = model.Description,
            Title = model.Title,
            StartDate = model.StartDate,
            NumberOfPosition = model.NumbersOfPositions,
            CreatedOn = DateTime.UtcNow,
            JobStatusLookUpId = 1
        };

        var job = await jobRepository.AddAsync(jobEntity);
        return job.Id;
    }

    public async Task<List<JobResponseModel>> GetAllJobs()
    {
        var jobs = await jobRepository.GetAllJobs();

        List<JobResponseModel> response = new();

        foreach (var job in jobs)
        {
            response.Add(new JobResponseModel()
            {
                Id = job.Id,
                Description = job.Description,
                Title = job.Title,
                StartDate = job.StartDate,
                NumberOfPositions = job.NumberOfPosition
            });
        }

        return response;
    }

    public async Task<JobResponseModel> GetJobById(int id)
    {
        var job = await jobRepository.GetJobById(id);
        return new JobResponseModel()
        {
            Id = job.Id,
            Description = job.Description,
            Title = job.Title,
            StartDate = job.StartDate,
            NumberOfPositions = job.NumberOfPosition
        };
    }
}
