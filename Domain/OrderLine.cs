namespace Domain
{
    public class OrderLine
    {
        public int OrderLineID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantiiy { get; set; }
        public int Price { get; set; }
    }
}