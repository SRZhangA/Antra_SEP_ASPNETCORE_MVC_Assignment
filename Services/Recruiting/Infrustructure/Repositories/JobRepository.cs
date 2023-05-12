using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrustructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrustructure.Repositories;

public class JobRepository : IJobRepository
{
    private readonly RecruitingDbContext dbContext;

    public JobRepository(RecruitingDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public async Task<List<Job>> GetAllJobs()
    {
        var jobs = await dbContext.Jobs.ToListAsync();
        return jobs;
    }

    public async Task<Job> GetJobById(int id)
    {
        var job = await dbContext.Jobs.FirstOrDefaultAsync(x => x.Id == id);
        return job ?? new();
    }
}
