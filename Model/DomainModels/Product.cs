

namespace Model.DomainModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
    }
}
