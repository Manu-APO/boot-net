using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<ProductBrand> ProductBrands { get; }

    DbSet<Product> Products { get; }

    DbSet<ProductType> ProductTypes { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}