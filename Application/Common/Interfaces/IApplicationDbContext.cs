namespace Application.Common.Interfaces;

using Domain.Entities;

using Microsoft.EntityFrameworkCore;

public interface IApplicationDbContext
{
    DbSet<ProductBrand> ProductBrands { get; }

    DbSet<Product> Products { get; }

    DbSet<ProductType> ProductTypes { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}