namespace PassGuard.Models
{
    public class User : DomainObject
    {
        public string MasterPassword { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public ProtectionLevel ProtectionLevel { get; set; }
        public ICollection<Service> Services { get; set; } = new List<Service>();
    }
}
