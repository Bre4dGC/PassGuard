namespace PassGuard.Models
{
    public class User : DomainObject
    {
        public string MasterPassword { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public ICollection<Service> Services { get; set; } = new List<Service>();
    }
}
