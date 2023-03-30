using Address.Entities;
using Address.Queries.Streets;
using Address.Repositories.Streets;
using MediatR;

namespace Address.Handlers.Streets;

public class GetStreetByIdHandler : IRequestHandler<GetStreetByIdQuery, Street>
{
    private readonly IStreetRepository _streetRepository;

    public GetStreetByIdHandler(IStreetRepository streetRepository)
    {
        _streetRepository = streetRepository;
    }

    public async Task<Street> Handle(GetStreetByIdQuery query, CancellationToken cancellationToken)
    {
        return await _streetRepository.GetStreetByIdAsync(query.Id);
    }
}
