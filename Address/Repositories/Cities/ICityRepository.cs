using Address.Entities;

namespace Address.Repositories.Cities;

public interface ICityRepository
{
    public Task<List<City>> GetCityListAsync();
    public Task<City> GetCityByIdAsync(int Id);
    public Task<City> AddCityAsync(City city);
    public Task<int> UpdateCityAsync(City city);
    public Task<int> DeleteCityAsync(int Id);
}
