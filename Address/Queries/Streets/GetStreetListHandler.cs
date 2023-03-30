using Address.Entities;
using Address.Queries.Streets;
using Address.Repositories.Streets;
using MediatR;

namespace Address.Handlers.Streets;

public class GetStreetListHandler : IRequestHandler<GetStreetListQuery, List<Street>>
{
    private readonly IStreetRepository _streetRepository;

    public GetStreetListHandler(IStreetRepository streetRepository)
    {
        _streetRepository = streetRepository;
    }

    public async Task<List<Street>> Handle(GetStreetListQuery query, CancellationToken cancellationToken)
    {
        return await _streetRepository.GetStreetListAsync();
    }
}