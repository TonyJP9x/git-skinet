using API.Dto;
using AutoMapper;
using Core.Entity;
using Core.Interface;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController: ControllerBase
    {
        private readonly IProductRepository _repo;
     
        private readonly IMapper _mapper;
        public ProductController(IProductRepository repo,IMapper mapper)
        {
            _repo = repo;
            
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
             var products = await _repo.GetProductsAsync();
            return Ok(_mapper.Map<List<Product>,List<ProductToReturnDto>>(products));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product =  await _repo.GetProductByIdAsync(id);
            return Ok(_mapper.Map<Product, ProductToReturnDto>(product));
             
        }

        [HttpGet("brands")]
        public async Task<ActionResult<List<ProductBrand>>> GetBr2andsAsync()
        {
            var brands = await _repo.GetBrandsAsync();
            return Ok(brands);
        }

        [HttpGet("types")]
        public async Task<ActionResult<List<ProductType>>> GetTypesAsync()
        {
            var types = await _repo.GetTypesAsync();
            return Ok(types);
        }
    }
}