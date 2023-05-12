using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;

namespace Infrustructure.Services;

public class JobService : IJobService
{
    public List<JobResponseModel> GetAllJobs()
    {
        var jobs = new List<JobResponseModel>()
        {
            new JobResponseModel(){Id=1, Title=".net", Description="need"},
            new JobResponseModel(){Id=2, Title="java", Description="need"},
            new JobResponseModel(){Id=3, Title="python", Description="need"},
            new JobResponseModel(){Id=4, Title="ruby", Description="need"}
        };

        return jobs;
    }

    public JobResponseModel GetJobById(int id)
    {
        return new JobResponseModel() { Id = 1, Title = ".net", Description = "need" };
    }
}
