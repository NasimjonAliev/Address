using Address.Entities;

namespace Address.Repositories.Streets;

public interface IStreetRepository
{
    public Task<List<Street>> GetStreetListAsync();
    public Task<Street> GetStreetByIdAsync(int Id);
    public Task<Street> AddStreetAsync(Street street);
    public Task<int> UpdateStreetAsync(Street street);
    public Task<int> DeleteStreetAsync(int Id);
}
