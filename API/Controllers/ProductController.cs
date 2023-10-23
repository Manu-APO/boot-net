namespace API.Controllers
{
    using Core.Entities;

    using Infrastructure.Data;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly StoreContext storeContext;

        public ProductController(StoreContext storeContext)
        {
            this.storeContext = storeContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            var products = await this.storeContext.Products.ToListAsync();

            return this.Ok(products);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var searchedProduct = await this.storeContext.Products.FindAsync(id);

            return this.Ok(searchedProduct);
        }
    }
}