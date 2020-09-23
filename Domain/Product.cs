namespace Domain
{
    public class Product
    {
        
        public int Id { get; set; }
        public string Title { get; set; } = "sam";
        public string Description { get; set; } = "superblad og dejlig";
        public int Price { get; set; } = 99;
        public Category Class { get; set; } = Category.Shirts;
    }
}
