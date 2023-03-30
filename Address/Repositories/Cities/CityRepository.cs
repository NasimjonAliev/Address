using Address.Context;
using Address.Entities;
using Microsoft.EntityFrameworkCore;

namespace Address.Repositories.Cities;

public class CityRepository : ICityRepository
{
    private readonly ApplicationDbContext _dbcontext;

    public CityRepository(ApplicationDbContext dbContext)
    {
        _dbcontext = dbContext;
    }

    public async Task<City> AddCityAsync(City city)
    {
        var result = _dbcontext.Cities.Add(city);
        await _dbcontext.SaveChangesAsync();
        return result.Entity;
    } 

    public async Task<int> DeleteCityAsync(int Id)
    {
        var delete = _dbcontext.Cities.Where(t => t.Id == Id).FirstOrDefaultAsync();
        return await _dbcontext.SaveChangesAsync();
    }

    public async Task<City> GetCityByIdAsync(int Id)
    {
        return await _dbcontext.Cities.Where(t => t.Id == Id).FirstOrDefaultAsync();
    }

    public async Task<List<City>> GetCityListAsync()
    {
        return await _dbcontext.Cities.ToListAsync();
    }

    public async Task<int> UpdateCityAsync(City city)
    {
        _dbcontext.Cities.Update(city);
        return await _dbcontext.SaveChangesAsync();
    }
}

