namespace Domain
{
    public class Customer : BaseDomain
    {
        public int UserId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }

    }
}