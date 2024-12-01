namespace PassGuard.Models
{
    public class Service : DomainObject
    {
        public Guid UserId { get; }
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime CreatedDate { get; }
        public ProtectionLevel ProtectionLevel { get; set; }
        public virtual User User { get; set; }
    }

    public enum ProtectionLevel
    {
        Weak, 
        Normal, 
        Strong
    }
}
