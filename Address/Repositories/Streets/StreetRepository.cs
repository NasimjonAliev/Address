using Address.Context;
using Address.Entities;
using Microsoft.EntityFrameworkCore;

namespace Address.Repositories.Streets;

public class StreetRepository : IStreetRepository
{
    private readonly ApplicationDbContext _dbcontext;

    public StreetRepository(ApplicationDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }

    public async Task<Street> AddStreetAsync(Street street)
    {
        var result = _dbcontext.Streets.Add(street);
        await _dbcontext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<int> DeleteStreetAsync(int Id)
    {
        var delete = _dbcontext.Streets.Where(x => x.Id == Id).FirstOrDefault();
        return await _dbcontext.SaveChangesAsync();
    }

    public async Task<Street> GetStreetByIdAsync(int Id)
    {
        return await _dbcontext.Streets.Where(x => x.Id == Id).FirstOrDefaultAsync();
    }

    public async Task<List<Street>> GetStreetListAsync()
    {
        return await _dbcontext.Streets.ToListAsync();
    }

    public async Task<int> UpdateStreetAsync(Street street)
    {
        _dbcontext.Streets.Update(street);
        return await _dbcontext.SaveChangesAsync();
    }
}
