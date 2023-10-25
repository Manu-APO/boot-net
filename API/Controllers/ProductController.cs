namespace API.Controllers
{
    using Domain.Entities;
    using Domain.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            var products = await this.productRepository.GetAllAsync();

            return this.Ok(products);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var searchedProduct = await this.productRepository.GetByIdAsync(id);

            return this.Ok(searchedProduct);
        }
    }
}