namespace Core.Interfaces
{
    using Core.Entities;

    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);

        Task<IReadOnlyList<Product>> GetAllAsync();
    }
}
