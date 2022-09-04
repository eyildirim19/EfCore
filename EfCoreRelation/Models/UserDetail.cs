namespace EfCoreRelation.Models
{
    public class UserDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Gender { get; set; }
        public DateTime CreateData { get; set; }

        public int UserId { get; set; }
        public User Users { get; set; }

    }
}