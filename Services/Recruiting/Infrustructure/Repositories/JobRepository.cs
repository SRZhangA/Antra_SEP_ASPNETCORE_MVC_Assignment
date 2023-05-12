using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrustructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrustructure.Repositories;

public class JobRepository : BaseRepository<Job>, IJobRepository
{
    public JobRepository(RecruitingDbContext dbContext) :base(dbContext)
    {

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
