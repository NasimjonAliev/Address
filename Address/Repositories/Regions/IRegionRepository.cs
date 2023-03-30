using Address.Entities;

namespace Address.Repositories.Regions;

public interface IRegionRepository
{
    public Task<List<Region>> GetRegionListAsync();
    public Task<Region> GetRegionByIdAsync(int Id);
    public Task<Region> AddRegionAsync(Region region);
    public Task<int> UpdateRegionAsync(Region region);
    public Task<int> DeleteRegionAsync(int Id);
}
