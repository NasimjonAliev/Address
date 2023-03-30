using Address.Context;
using Address.Entities;
using Microsoft.EntityFrameworkCore;

namespace Address.Repositories.Regions;

public class RegionRepository: IRegionRepository

{
    private readonly ApplicationDbContext _dbcontext;

    public RegionRepository(ApplicationDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }

    public async Task<Region> AddRegionAsync(Region region)
    {
        var result = _dbcontext.Regions.Add(region);
        await _dbcontext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<int> DeleteRegionAsync(int Id)
    {
        var delete = _dbcontext.Regions.Where(x => x.Id == Id).FirstOrDefault();
        return await _dbcontext.SaveChangesAsync();
    }

    public async Task<Region> GetRegionByIdAsync(int Id)
    {
        return await _dbcontext.Regions.Where(x => x.Id == Id).FirstOrDefaultAsync();
    }

    public async Task<List<Region>> GetRegionListAsync()
    {
        return await _dbcontext.Regions.ToListAsync();
    }

    public async Task<int> UpdateRegionAsync(Region region)
    {
        _dbcontext.Regions.Update(region);
        return await _dbcontext.SaveChangesAsync();
    }

}