namespace core.Entities
{
    public class PasswordResets
    {
        public string Email { get; set; }
        public string Token { get; set; }
        public DateTime CreatrdAt { get; set; }
    }
}
