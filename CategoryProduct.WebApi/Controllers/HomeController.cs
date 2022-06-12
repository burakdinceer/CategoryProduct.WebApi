using CategoryProduct.WebApi.Interfaces;
using CategoryProduct.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CategoryProduct.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {


        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<Category> _categoryRepository;
        private readonly IGenericRepository<ProductCategory> _productCategoryRepository;

        public HomeController(IGenericRepository<Product> productRepository,

            IGenericRepository<Category> categoryRepository,

            IGenericRepository<ProductCategory> productCategoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _productCategoryRepository = productCategoryRepository;
        }




        [HttpGet("[action]")]
        public IActionResult GetProductList()
        {
            var gt = _productRepository.TGetAll();

            return Ok(gt);
        }


        [HttpGet("[action]")]
        public IActionResult GetProductId(int id)
        {
            var gtId = _productRepository.GetT(id);
            return Ok(gtId);
        }





    }
}
