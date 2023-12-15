namespace MinhaAPI.DTO
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int OriginalPrice { get; set; }
        public int CurrentPrice { get; set; }
        public int Discount { get; set; }
        public int Buyers { get; set;}
    }
}   
