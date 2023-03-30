using Address.Models;

namespace Address.Repositories.Countries;

public interface ICountryRepository
{
    public Task<List<Country>> GetCountryListAsync();
    public Task<Country> GetCountryByIdAsync(int Id);
    public Task<Country> AddCountryAsync(Country country);
    public Task<int> UpdateCountryAsync(Country country);
    public Task<int> DeleteCountryAsync(int Id);
}
