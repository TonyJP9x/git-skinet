namespace Core.Entity
{
    public class ProductType : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}