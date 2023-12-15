namespace MinhaAPI.Entity
{
    public class ProductEntity
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OriginalPrice { get; set; }
        public string CurrentPrice { get; set; }
        public string Discount { get; set; }
        public string Buyers { get; set; }
    }
}
