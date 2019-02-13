namespace WebApi.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; } // will be an email address
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}