using Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Products.Queries.GetProduct;

public record GetProductQuery : IRequest<ProductDto>
{
    public int Id { get; init; }
}

public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductDto>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetProductQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ProductDto> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        return await _context.Products
            .Where(p => p.Id == request.Id)
            .ProjectTo<ProductDto>(_mapper.ConfigurationProvider)
            .SingleAsync(cancellationToken);
    }
}