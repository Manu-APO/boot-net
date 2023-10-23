namespace Infrastructure.Data
{
    using Core.Entities;
    using Core.Interfaces;

    using Microsoft.EntityFrameworkCore;

    public class ProductRepository : IProductRepository
    {
        private readonly DbSet<Product> products;

        public ProductRepository(StoreContext storeContext)
        {
            this.products = storeContext.Products;
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await this.products.FindAsync(id);
        }

        public async Task<IReadOnlyList<Product>> GetAllAsync()
        {
            return await this.products.ToListAsync();
        }
    }
}
