namespace EfCoreRelation.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserDetail UserDetay { get; set; }
        public List<Order> Order { get; set; }
    }
}
