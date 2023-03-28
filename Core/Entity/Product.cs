using Core.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entity
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string  PictureUrl { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductBrandId { get; set; }

        [ForeignKey("ProductTypeId")]
        public ProductType ProductType { get; set; }
        [ForeignKey("ProductBrandId")]
        public ProductBrand ProductBrand { get; set; }
    }
}