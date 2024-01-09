namespace EcoHerbalist.Data.DbModels
{
    public class ProductCategories
    {
        public Guid CategoryId { get; set; }
        public Guid ProductId { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
