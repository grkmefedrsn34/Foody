namespace Foody.EntitiyLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public  int Stock { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
    }
}
