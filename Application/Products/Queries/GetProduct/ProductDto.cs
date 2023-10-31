using AutoMapper;
using Domain.Entities;

namespace Application.Products.Queries.GetProduct;

public class ProductDto
{
    public Guid Id { get; init; }

    public string? Name { get; init; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Product, ProductDto>();
        }
    }
}