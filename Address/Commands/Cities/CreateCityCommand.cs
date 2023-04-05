﻿using Address.Context;
using Address.Entities;
using AutoMapper;
using MediatR;

namespace Address.Commands.Cities;

public class CreateCityCommand : IRequest<int>
{
    public string Name { get; set; }
    public uint PostIndex { get; set; }
    public int RegionId { get; set; }
}

public class CreateCityHandler : IRequestHandler<CreateCityCommand, int>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CreateCityHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateCityCommand command, CancellationToken cancellationToken)
    {
        var city = _mapper.Map<City>(command);

        _context.Cities.Add(city);

        await _context.SaveChangesAsync();

        return city.Id;
    }
}
