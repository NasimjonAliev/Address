using Address.Context;
using Address.Models;
using Microsoft.EntityFrameworkCore;

namespace Address.Repositories.Countries;

public class CountryRepository : ICountryRepository
{
    private readonly ApplicationDbContext _dbcontext;

    public CountryRepository(ApplicationDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }

    public async Task<Country> AddCountryAsync(Country country)
    {
        var result = _dbcontext.Countries.Add(country);
        await _dbcontext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<int> DeleteCountryAsync(int Id)
    {
        var delete = _dbcontext.Countries.Where(x => x.Id == Id).FirstOrDefault();
        return await _dbcontext.SaveChangesAsync();
    }

    public async Task<Country> GetCountryByIdAsync(int Id)
    {
        return await _dbcontext.Countries.Where(x => x.Id == Id).FirstOrDefaultAsync();
    }

    public async Task<List<Country>> GetCountryListAsync()
    {
        return await _dbcontext.Countries.ToListAsync();
    }

    public async Task<int> UpdateCountryAsync(Country country)
    {
        _dbcontext.Countries.Update(country);
        return await _dbcontext.SaveChangesAsync();
    }

}
