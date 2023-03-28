using API.Dto;
using AutoMapper;
using Core.Entity;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController: ControllerBase
    {
     
        private readonly IGenericRepository<Product> _productsRepo;
        private readonly IGenericRepository<ProductBrand> _brandsRepo;
        private readonly IGenericRepository<ProductType> _typesRepo;
     
        private readonly IMapper _mapper;
        public ProductController(IGenericRepository<Product> productsRepo, IGenericRepository<ProductBrand> brandsRepo, IGenericRepository<ProductType> typesRepo,IMapper mapper)
        {
            _typesRepo = typesRepo;
            _brandsRepo = brandsRepo;
            _productsRepo = productsRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
             var products = await _productsRepo.GetAllAsync();
            return Ok(_mapper.Map<List<Product>,List<ProductToReturnDto>>(products));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product =  await _productsRepo.GetIdAsync(id);
            return Ok(_mapper.Map<Product, ProductToReturnDto>(product));
             
        }

        [HttpGet("brands")]
        public async Task<ActionResult<List<ProductBrand>>> GetBr2andsAsync()
        {
            var brands = await _brandsRepo.GetAllAsync();
            return Ok(brands);
        }

        [HttpGet("types")]
        public async Task<ActionResult<List<ProductType>>> GetTypesAsync()
        {
            var types = await _typesRepo.GetAllAsync();
            return Ok(types);
        }
    }
}