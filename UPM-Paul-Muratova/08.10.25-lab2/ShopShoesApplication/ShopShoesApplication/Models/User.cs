namespace ShopShoesApplication.Models
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
